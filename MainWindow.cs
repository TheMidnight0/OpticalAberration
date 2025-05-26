using System.Drawing.Drawing2D;

namespace OpticalAberration
{
    public partial class MainWindow : Form
    {
        public int ExitDistance { get; set; } = 200;
        public int LensRadiusLeft { get; set; } = 20;
        public int LensRadiusRight { get; set; } = 20;
        public int LensHeight { get; set; } = 300;
        public int RayCount { get; set; } = 75;
        public bool RainbowPattern { get; set; } = false;

        Settings? settings;
        List<(Color color, int value)> raysExits = [];

        static readonly Dictionary<Color, int> colorWaveLength = new() {
            {Color.Red, 685}, {Color.Orange, 605}, {Color.Yellow, 580}, {Color.Green, 525},
            {Color.Cyan, 487}, {Color.Blue, 465}, {Color.Purple, 415}, {Color.Violet, 400}, {Color.White, 555}
        };
        readonly int lensX;
        readonly int lensY;

        public MainWindow()
        {
            InitializeComponent();
            lensX = field.Width / 3;
            lensY = field.Height / 2;
            field.Paint += Field_Paint;
            exit.Paint += Exit_Paint;
        }

        private void Exit_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(exit.Width, exit.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (raysExits.Count == 0) return;
            int centerRay = DrawRay(lensY);
            int brushWidth = 25;
            int brushOpacity = 5;
            foreach ((Color color, int value) in raysExits)
            {
                Pen pen = new(Color.FromArgb(brushOpacity, color.R, color.G, color.B), brushWidth);
                int newRay = centerRay - value;
                if (Math.Abs(newRay) <= brushWidth) g.FillEllipse(new SolidBrush(Color.FromArgb(brushOpacity, color.R, color.G, color.B)), exit.Width / 2 - brushWidth / 2, exit.Height / 2 - brushWidth / 2, brushWidth, brushWidth);
                g.DrawEllipse(pen, exit.Width / 2 - newRay, exit.Height / 2 - newRay, newRay * 2, newRay * 2);
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
            int lenWidth = Math.Max(Math.Abs(LensRadiusLeft < 0 ? LensRadiusLeft : 0), Math.Abs(LensRadiusRight < 0 ? LensRadiusRight : 0)) + 2;
            points = [
            new(lensX - lenWidth, lensY - LensHeight / 2),
            new(lensX + lenWidth, lensY - LensHeight / 2),
            new(lensX + lenWidth + LensRadiusRight, lensY),
            new(lensX + lenWidth, lensY + LensHeight / 2),
            new(lensX - lenWidth, lensY + LensHeight / 2),
            new(lensX - lenWidth - LensRadiusLeft, lensY)
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
            g.DrawLine(new(Color.Blue, 3), new(lensX + ExitDistance, 0), new(lensX + ExitDistance, field.Height));
        }

        private void DrawRays(ref Bitmap target)
        {
            Graphics g = Graphics.FromImage(target);
            List<(Color, int)> exits = [];
            Color[] colors = [Color.Red, Color.Orange, Color.Yellow, Color.Green, Color.Cyan, Color.Blue, Color.Purple, Color.Violet];

            for (int i = 1; i < RayCount + 1; i++)
            {
                Color color = RainbowPattern ? colors[(i - 1) % 8] : Color.White;
                exits.Add((color, DrawRay(lensY - LensHeight / 2 + LensHeight * (RayCount - i + 1) / (RayCount + 1), g, color)));
            }

            raysExits = exits;
            exit.Refresh();
        }

        private int DrawRay(int enterY, Graphics? g = null, Color? color = null)
        {
            double angle = (Math.PI * 0 / 180);
            (double X, double Y) move_vector = (Math.Cos(angle), Math.Sin(angle));
            int endX = lensX;
            int endY = enterY;
            int startX = 0;
            int startY = (int)(endY + ((startX - endX) / move_vector.X) * move_vector.Y);
            Color col = color != null ? color.Value : Color.White;
            int waveLength = colorWaveLength[col];
            Pen pen = new(Color.FromArgb(100, col.R, col.G, col.B), 1);

            g?.DrawLine(pen, startX, startY, endX, endY);

            angle = GetAngle(endX, endY, lensY, angle, LensRadiusLeft, LensRadiusRight, 1.5, waveLength);

            move_vector = (Math.Cos(angle), Math.Sin(angle));
            startX = endX;
            startY = endY;

            endX = ExitDistance + lensX;
            endY = (int)(startY + ((endX - startX) / move_vector.X) * move_vector.Y);
            g?.DrawLine(pen, startX, startY, endX, endY);

            return endY;
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
            // ????????? ??????? ?? ????
            double deltaY = (focalLength * 0.25 * (Math.Abs(startY - lensY) / LensHeight * 2));
            double focalX;
            if (LensRadiusRight >= 0) focalX = startX + focalLength + (waveLength - 555) * 0.08 - deltaY;
            else focalX = startX - focalLength - (waveLength - 555) * 0.08 + deltaY;
            (double X, double Y) = (Math.Cos(angle), Math.Sin(angle));
            double focalY = (int)(lensY + ((focalX - startX) / X) * Y);

            // ?????????? Math.Atan2, ????? ???????? ???? ? ????????
            double radians = Math.Atan2(focalY - startY, focalX - startX);

            // ????????? ??????? ? ???????
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
