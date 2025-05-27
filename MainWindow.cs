using System.Drawing;
using System.Drawing.Drawing2D;

namespace OpticalAberration
{
    public partial class MainWindow : Form
    {
        public int ExitDistance { get; set; } = 120;
        public int LensRadiusLeft { get; set; } = 20;
        public int LensRadiusRight { get; set; } = 20;
        public int LensHeight { get; set; } = 300;
        private int LensThickness => Math.Max(Math.Abs(LensRadiusLeft < 0 ? LensRadiusLeft : 0), Math.Abs(LensRadiusRight < 0 ? LensRadiusRight : 0)) + 3;
        int LensX => field.Width / 3 + (LensRadiusLeft > 0 ? LensRadiusLeft : 0) - (LensRadiusRight > 0 ? LensRadiusRight : 0);
        int LensY => field.Height / 2;
        public int RayCount { get; set; } = 200;
        public int RayStrength { get; set; } = 100;
        public int Angle { get; set; } = 0;
        public int ImageBlurStrength { get; set; } = 15;
        public bool RainbowPattern { get; set; } = false;
        public bool DrawAfterExit { get; set; } = true;

        Settings? settings;
        List<(Color color, int value)> raysExits = [];

        static readonly Dictionary<Color, int> colorWaveLength = new() {
            {Color.Red, 685}, {Color.Orange, 605}, {Color.Yellow, 580}, {Color.Green, 525},
            {Color.Cyan, 487}, {Color.Blue, 465}, {Color.Purple, 415}, {Color.Violet, 400}, {Color.White, 555}
        };

        public MainWindow()
        {
            InitializeComponent();
            field.Paint += Field_Paint;
            exit.Paint += Exit_Paint;
            Resize += MainWindow_Resize;
            field.Location = new(12, 12);
            field.Width = Width * 2 / 3 - 12;
            exit.Width = Width / 3 - 32;
            exit.Height = Height - 135;
            field.Height = Height - 135;
            exit.Location = new(18 + field.Width, 12);
            openSettings.Location = new(Width / 2 - openSettings.Width / 2, exit.Height + 24);
            field.Invalidate();
        }

        private void MainWindow_Resize(object? sender, EventArgs e)
        {
            field.Location = new(12, 12);
            field.Width = Width * 2 / 3 - 12;
            exit.Width = Width / 3 - 32;
            exit.Height = Height - 135;
            field.Height = Height - 135;
            exit.Location = new(18 + field.Width, 12);
            LensHeight = Math.Min(field.Height, LensHeight);
            openSettings.Location = new(Width / 2 - openSettings.Width / 2 - 8, exit.Height + 24);
            field.Invalidate();
        }

        private void Exit_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(exit.Width, exit.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (raysExits.Count == 0) return;
            int? centerRay = DrawRay(LensY);
            if (centerRay == null) return;
            int brushOpacity = (int)(RayStrength / (float)ImageBlurStrength);
            foreach ((Color color, int value) in raysExits)
            {
                Pen pen = new(Color.FromArgb(brushOpacity, color.R, color.G, color.B), ImageBlurStrength);
                int newRay = Math.Abs(centerRay.Value - value);
                if (newRay < 0) continue;
                if (newRay < ImageBlurStrength)
                {
                    if (newRay == 0)
                    {
                        newRay = 1;
                        g.DrawEllipse(new(pen.Color, 4), exit.Width / 2 - 2, exit.Height / 2 - 2, 4, 4);
                    }
                    else g.DrawEllipse(new(pen.Color, newRay * 2), exit.Width / 2 - newRay, exit.Height / 2 - newRay, newRay * 2, newRay * 2);
                }
                //if (newRay == 0) g.DrawEllipse(new(pen.Color, 2), exit.Width / 2 - 2, exit.Height / 2 - 2, 4, 4);
                else g.DrawEllipse(pen, exit.Width / 2 - newRay, exit.Height / 2 - newRay, newRay * 2, newRay * 2);
            }
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private void Field_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(field.Width, field.Height);
            DrawLens(ref bitmap);
            DrawRays(ref bitmap);
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private void DrawLens(ref Bitmap target)
        {
            Graphics g = Graphics.FromImage(target);
            g.Clear(Color.Black);
            GraphicsPath path = new();
            path.StartFigure();
            PointF[] points;
            points = [
            new(LensX - LensThickness, LensY - LensHeight / 2),
            new(LensX + LensThickness, LensY - LensHeight / 2),
            new(LensX + LensThickness + LensRadiusRight, LensY),
            new(LensX + LensThickness, LensY + LensHeight / 2),
            new(LensX - LensThickness, LensY + LensHeight / 2),
            new(LensX - LensThickness - LensRadiusLeft, LensY)
            ];
            path.AddLine(points[0], points[1]);
            path.AddCurve([points[1], points[2], points[3]]);
            path.AddLine(points[3], points[4]);
            path.AddCurve([points[4], points[5], points[0]]);
            path.CloseFigure();
            Brush brush = new SolidBrush(Color.FromArgb(0, 171, 255));
            Pen outline = new(Color.FromArgb(0, 0, 255), 2);
            g.FillPath(brush, path);
            g.DrawPath(outline, path);
            g.DrawLine(new(Color.Blue, 3), new(field.Width / 3 + 60 + ExitDistance, 0), new(field.Width / 3 + 60 + ExitDistance, field.Height));
        }

        private void DrawRays(ref Bitmap target)
        {
            Graphics g = Graphics.FromImage(target);
            List<(Color, int)> exits = [];
            Color[] colors = [Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Purple, Color.Violet];

            for (int i = 1; i < RayCount + 1; i++)
            {
                Color color = RainbowPattern ? colors[(i - 1) % 8] : Color.White;
                int? rayEntry = DrawRay(LensY - LensHeight / 2 + LensHeight * (RayCount - i + 1) / (RayCount + 1), g, color);
                if (rayEntry != null) exits.Add((color, rayEntry.Value));
            }

            raysExits = exits;
            exit.Refresh();
        }

        private int? DrawRay(int enterY, Graphics? g = null, Color? color = null)
        {
            GraphicsPath path = new();
            double angleRad = Math.PI * Angle / 180;
            (double X, double Y) move_vector = (Math.Cos(angleRad), Math.Sin(angleRad));
            int endX = LensX;
            int endY = enterY;
            int startX = 0;
            int startY = (int)(endY + ((startX - endX) / move_vector.X) * move_vector.Y);
            Color col = color != null ? color.Value : Color.White;
            int waveLength = colorWaveLength[col];
            Pen pen = new(Color.FromArgb(RayStrength, col.R, col.G, col.B), 1);
            double newAngleRad = GetAngle(endX, endY, LensY, angleRad, LensRadiusLeft, LensRadiusRight, 1.5, waveLength);

            (Point start, Point exit) lensPoints = GetLensEntryPoints(enterY, angleRad, newAngleRad);
            if (lensPoints.start == Point.Empty || lensPoints.exit == Point.Empty) return null;
            path.AddLine(startX, startY, lensPoints.start.X, lensPoints.start.Y);
            path.AddLine(lensPoints.start.X, lensPoints.start.Y,
                lensPoints.exit.X, lensPoints.exit.Y);
            move_vector = (Math.Cos(newAngleRad), Math.Sin(newAngleRad));
            if (move_vector.X < 0)
            {
                move_vector.X *= -1;
                move_vector.Y *= -1;
            }
            startX = endX;
            startY = endY;

            endX = field.Width / 3 + 60 + ExitDistance;
            endY = (int)(startY + (endX - startX) / move_vector.X * move_vector.Y);
            path.AddLine(lensPoints.exit.X, lensPoints.exit.Y, endX, endY);

            g?.DrawPath(pen, path);
            int result = endY;
            if (DrawAfterExit)
            {
                startX = endX; startY = endY;
                endX = field.Width;
                endY = (int)(startY + (endX - startX) / move_vector.X * move_vector.Y);
                g?.DrawLine(new(Color.FromArgb(pen.Color.A / 2, pen.Color.R, pen.Color.G, pen.Color.B), pen.Width), startX, startY, endX, endY);
            }

            return result;
        }

        private (Point start, Point exit) GetLensEntryPoints(double Y, double startAngle, double endAngle)
        {
            Point start = new(), exit = new();
            Func<int, int> Fstart = y =>
            {
                return (int)(LensX - LensThickness - LensRadiusLeft * Math.Cos(Math.PI * 45 * (Math.Abs(LensY - y) / (LensHeight / 2.0)) / 90));
            };
            Func<int, int> Fend = y =>
            {
                return (int)(LensX + LensThickness + LensRadiusRight * Math.Cos(Math.PI * 45 * (Math.Abs(LensY - y) / (LensHeight / 2.0)) / 90));
            };
            (double X, double Y) move_vector = (Math.Cos(startAngle), Math.Sin(startAngle));
            if (move_vector.X < 0)
            {
                move_vector.X *= -1;
                move_vector.Y *= -1;
            }
            start = new(Fstart((int)Y), (int)Y);

            int minVal = 99999999;
            move_vector = (Math.Cos(endAngle), Math.Sin(endAngle));
            if (move_vector.X < 0)
            {
                move_vector.X *= -1;
                move_vector.Y *= -1;
            }
            for (int radius = 0; radius < Math.Abs(LensRadiusRight) + 1; radius++)
            {
                int tempX = LensX + LensThickness + radius * (LensRadiusRight < 0 ? -1 : 1);
                int tempY = (int)(Y + ((tempX - LensX) / move_vector.X) * move_vector.Y);
                if (Math.Abs(Fend(tempY) - tempX) < minVal)
                {
                    minVal = Math.Abs(Fend(tempY) - tempX);
                    exit = new(tempX, tempY);
                }
                if (minVal == 0) break;
            }
            if (minVal > 0)
            {
                int tempY = LensY + LensHeight / 2 * (move_vector.Y < 0 ? -1 : 1);
                int tempX = (int)(LensX + ((tempY - start.Y) / move_vector.Y) * move_vector.X);
                if (tempX >= LensX - LensThickness && tempX <= LensX + LensThickness)
                {
                    exit = new(tempX, tempY);
                }
            }
            //if (minVal != 0 ) return (Point.Empty, Point.Empty);
            if (start.Y < LensY - LensHeight / 2 || start.Y > LensY + LensHeight / 2) return (Point.Empty, Point.Empty);
            if (exit.Y < LensY - LensHeight / 2 || exit.Y > LensY + LensHeight / 2) return (Point.Empty, Point.Empty);
            //{
            //    int newY = Math.Min(Math.Max(exit.Y, LensY - LensHeight / 2), LensY + LensHeight / 2);
            //    PointF vector = new((exit.X - start.X) / (float)Math.Max(exit.X - start.X, exit.Y - start.Y), (exit.Y - start.Y) / (float)Math.Max(exit.X - start.X, exit.Y - start.Y));
            //    int newX = (int)(start.X + ((newY - start.Y) / vector.Y) * vector.X);
            //   exit = new(newX, newY);
            //}

            return (start, exit);
        }

        public double GetAngle(
            double startX, double startY,
            double lensY,
            double angle,
            double R1, double R2, double n,
            double waveLength)
        {
            double focalLength = FocalLength(R1, -R2, n);
            if (focalLength == double.PositiveInfinity) return angle;
            double deltaY = (focalLength * 0.25 * (Math.Abs(startY - lensY) / LensHeight * 2));
            double focalX;
            if (R1 + R2 > 0) focalX = startX + focalLength + (waveLength - 555) * 0.08 - deltaY;
            else focalX = startX - focalLength - (waveLength - 555) * 0.08 + deltaY;
            (double X, double Y) = (Math.Cos(angle), Math.Sin(angle));
            double focalY = (int)(lensY + ((focalX - startX) / X) * Y);

            double radians = Math.Atan2(focalY - startY, focalX - startX);

            if (focalLength < 0) radians *= -1;

            return radians;
        }

        static double FocalLength(double R1, double R2, double n)
        {
            double d1, d2;
            if (R1 != 0) d1 = 1 / (R1 * 10);
            else d1 = 0.1;
            if (R2 != 0) d2 = 1 / (R2 * 10);
            else d2 = 0.1;

            if (d1 == 0.1 && d2 == 0.1 || n == 1 || d1 == d2) return double.PositiveInfinity;

            return 1 / ((n - 1) * (d1 - d2));
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new Settings(this);
                settings.Show();
            }

        }
    }
}
