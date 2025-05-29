using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reflection.Metadata.Ecma335;

namespace OpticalAberration
{
    public partial class MainWindow : Form
    {
        public int ImageDistance
        {
            get
            {
                int rightX = (LensRadiusRight > 0) ? (LensRadiusRightCenter.X + LensRadiusRight) : (LensX + LensThickness / 2);
                if (imageDistance < rightX) imageDistance = rightX;
                return imageDistance;
            }
            set
            {
                imageDistance = value;
            }
        }
        int imageDistance = 720;
        public int LensRadiusRight { get; set; } = 400;
        public Point LensRadiusRightCenter
        {
            get
            {
                if (LensHeight / 2 + 1 > Math.Abs(LensRadiusRight)) LensRadiusRight = (LensHeight / 2 + 1) * (LensRadiusRight > 0 ? 1 : -1);
                double temp = Math.Sqrt(Math.Pow(LensRadiusRight, 2) - Math.Pow((LensY - LensHeight / 2) - LensY, 2));
                return new((int)((LensX + LensThickness / 2) - (LensRadiusRight > 0 ? temp : -temp)), LensY);
            }
        }
        public int LensRadiusLeft { get; set; } = 400;
        public Point LensRadiusLeftCenter
        {
            get
            {
                if (LensHeight / 2 + 1 > Math.Abs(LensRadiusLeft)) LensRadiusLeft = (LensHeight / 2 + 1) * (LensRadiusLeft > 0 ? 1 : -1);
                double temp = Math.Sqrt(Math.Pow(LensRadiusLeft, 2) - Math.Pow((LensY - LensHeight / 2) - LensY, 2));
                return new((int)(LensX - LensThickness / 2 + (LensRadiusLeft > 0 ? temp : -temp)), LensY);
            }
        }
        public int LensHeight { get; set; } = 300;
        public int LensThickness { get; set; } = 1;
        public int LensX => field.Width / 3;
        public int LensY => field.Height / 2;
        public int RayCount { get; set; } = 200;
        public float RayStepLength { get; set; } = 1;
        public int RayStrength { get; set; } = 100;
        public int Angle { get; set; } = 0;
        public int ImageBlurStrength { get; set; } = 15;
        public float LensRefractIndex { get; set; } = 1.5f;
        public bool DrawAfterExit { get; set; } = true;
        public bool AllowTotalReflect {  get; set; } = false;
        public List<Color> RayColors { get; set; } = [];

        Settings? settings;
        List<(Color color, int? value)> raysExits = [];

        static readonly Dictionary<Color, int> colorWaveLength = new() {
            {Color.Red, 685}, {Color.Orange, 605}, {Color.Yellow, 580}, {Color.Green, 525},
            {Color.Cyan, 487}, {Color.Blue, 465}, {Color.Purple, 415}, {Color.Violet, 400}, {Color.White, 555}
        };

        public MainWindow()
        {
            InitializeComponent();
            field.Paint += Field_Paint;
            image.Paint += Image_Paint;
            Resize += MainWindow_Resize;
            field.Location = new(12, 12);
            field.Width = Width * 2 / 3 - 12;
            image.Width = Width / 3 - 32;
            image.Height = Height - 135;
            field.Height = Height - 135;
            image.Location = new(18 + field.Width, 12);
            openSettings.Location = new(Width / 2 - openSettings.Width / 2, image.Height + 24);
            field.Invalidate();
        }

        private async void MainWindow_Resize(object? sender, EventArgs e)
        {
            if (((Control?)sender) != null && ((Control?)sender)?.Height != 34)
            {
                field.Location = new(12, 12);
                field.Width = Width * 2 / 3 - 12;
                image.Width = Width / 3 - 32;
                image.Height = Height - 135;
                field.Height = Height - 135;
                image.Location = new(18 + field.Width, 12);
                LensHeight = Math.Min(field.Height, LensHeight);
                openSettings.Location = new(Width / 2 - openSettings.Width / 2 - 8, image.Height + 24);
                ImageDistance = ImageDistance > field.Width - 7 ? field.Width - 7 : ImageDistance;
                await Task.Run(field.Invalidate);
            }
        }

        private void Image_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(image.Width, image.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (raysExits.Count == 0) return;
            int? centerRay = DrawRay(LensY);
            if (centerRay == null) return;
            int offset = image.Height / 2 - centerRay.Value;
            int brushOpacity = (int)(RayStrength / (ImageBlurStrength * 0.5));
            for (int i = 0; i < raysExits.Count / 2 + 1; i++)
            {
                Color color = raysExits[i].color;
                Pen pen = new(Color.FromArgb(brushOpacity, color.R, color.G, color.B), ImageBlurStrength);
                if (raysExits[i].value is int val1 && raysExits[^(i + 1)].value is int val2) {
                    if (raysExits[i] == raysExits[^(i + 1)] || raysExits[i].value == null && raysExits[i].value != null || raysExits[i].value != null && raysExits[i].value == null)
                    {
                        g.DrawEllipse(pen, image.Width / 2f - ImageBlurStrength / 2f, offset + val1 - ImageBlurStrength / 2f, ImageBlurStrength, ImageBlurStrength);
                    }
                    else if (raysExits[i].value != null && raysExits[i].value != null)
                    {
                        float radius = Math.Abs(val2 - val1) / 2f;
                        int minY = Math.Min(val1, val2);
                        if (radius * 2 <= ImageBlurStrength) g.DrawEllipse(new(pen.Color, radius * 2), image.Width / 2f - radius, offset + minY, radius * 2, radius * 2);
                        else g.DrawEllipse(pen, image.Width / 2f - radius, offset + minY, radius * 2, radius * 2);
                    }
                }
            }
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private void Field_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(field.Width, field.Height);
            DrawLens(ref bitmap);
            DrawRays(ref bitmap);
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private void DrawLens(ref Bitmap target)
        {
            Graphics g = Graphics.FromImage(target);
            g.Clear(Color.Black);
            GraphicsPath left = new();
            GraphicsPath right = new();
            GraphicsPath width = new();
            GraphicsPath GP = new();
            left.AddEllipse(LensRadiusLeftCenter.X - Math.Abs(LensRadiusLeft), LensRadiusLeftCenter.Y - Math.Abs(LensRadiusLeft),
                Math.Abs(LensRadiusLeft) * 2, Math.Abs(LensRadiusLeft) * 2);
            right.AddEllipse(LensRadiusRightCenter.X - Math.Abs(LensRadiusRight), LensRadiusRightCenter.Y - Math.Abs(LensRadiusRight),
                Math.Abs(LensRadiusRight * 2), Math.Abs(LensRadiusRight) * 2);

            width.AddRectangle(new(LensX - LensThickness / 2, LensY - LensHeight / 2, LensThickness, LensHeight));
            var lens = new Region(width);
            if (LensRadiusLeft > 0)
            {
                Region round = new(left);
                GraphicsPath roundCrop = new();
                int leftX = (LensRadiusLeft > 0) ? (LensRadiusLeftCenter.X - LensRadiusLeft) : (LensX - LensThickness / 2);
                roundCrop.AddRectangle(new(leftX, LensY - LensHeight / 2, LensX - leftX, LensHeight));
                round.Intersect(roundCrop);
                lens.Union(round);
            }
            if (LensRadiusRight > 0)
            {
                Region round = new(right);
                GraphicsPath roundCrop = new();
                int rightX = (LensRadiusRight > 0) ? (LensRadiusRightCenter.X + LensRadiusRight) : (LensX + LensThickness / 2);
                roundCrop.AddRectangle(new(LensX, LensY - LensHeight / 2, rightX - LensX, LensHeight));
                round.Intersect(roundCrop);
                lens.Union(round);
            }
            if (LensRadiusLeft < 0) lens.Exclude(left);
            if (LensRadiusRight < 0) lens.Exclude(right);
            try
            {
                GP.AddRectangles(lens.GetRegionScans(new()));
                Brush brush = new SolidBrush(Color.FromArgb(0, 171, 255));
                Pen outline = new(Color.FromArgb(0, 0, 255), 2);
                g.FillRegion(brush, lens);
            }
            catch { }
            g.DrawLine(new(Color.Blue, 3), new(ImageDistance, 0), new(ImageDistance, field.Height));
        }

        private void DrawRays(ref Bitmap target)
        {
            Graphics g = Graphics.FromImage(target);
            List<(Color, int?)> exits = [];

            for (int i = 1; i < RayCount + 1; i++)
            {
                if (RayColors.Count > 0)
                {
                    Color color = RayColors[(i - 1) % RayColors.Count];
                    int? rayEntry = DrawRay(LensY - LensHeight / 2 + LensHeight * ((RayCount - 1) / RayColors.Count + 1 - ((i - 1) / RayColors.Count)) / ((RayCount - 1) / RayColors.Count + 2), g, color);
                    exits.Add((color, rayEntry));
                } else
                {
                    int? rayEntry = DrawRay(LensY - LensHeight / 2 + LensHeight * (RayCount + 1 - i) / (RayCount + 1), g, Color.White);
                    exits.Add((Color.White, rayEntry));
                }
            }

            raysExits = exits;
            image.Invalidate();
        }

        private int? DrawRay(int enterY, Graphics? g = null, Color? color = null)
        {
            GraphicsPath path = new();
            double angleRad = Math.PI * (Angle + 90) / 180;
            (double X, double Y) move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
            Func<double, double> Fstart = y =>
            {
                return LensRadiusLeftCenter.X - Math.Sqrt(Math.Pow(LensRadiusLeft, 2) - Math.Pow(y - LensRadiusLeftCenter.Y, 2)) * (LensRadiusLeft > 0 ? 1 : -1);
            };
            Func<double, double> Fend = y =>
            {
                return LensRadiusRightCenter.X + Math.Sqrt(Math.Pow(LensRadiusRight, 2) - Math.Pow(y - LensRadiusRightCenter.Y, 2)) * (LensRadiusRight > 0 ? 1 : -1);
            };
            Func<double, double, bool> InLens = (X, Y) =>
            {
                return Y >= (LensY - LensHeight / 2) && Y <= (LensY + LensHeight / 2) &&
                    X <= Fend(Y) && X >= Fstart(Y);
            };

            Color col = color != null ? color.Value : Color.White;
            Pen pen = new(Color.FromArgb(RayStrength, col.R, col.G, col.B), 1);

            double prevY = enterY;
            double prevX = LensX;
            double startX = 0;
            double startY = FindY(prevX, startX, prevY, angleRad);
            double nextX = startX + move_vector.X * RayStepLength;
            double nextY = startY - move_vector.Y * RayStepLength;
            bool prevInLens = false;

            int waveLength = colorWaveLength[col];

            while (nextX < ImageDistance && !(move_vector.X < 0 && (nextX < 0 || nextY < 0 || nextY > field.Height)))
            {
                prevX = nextX; prevY = nextY;
                nextX += move_vector.X * RayStepLength;
                nextY -= move_vector.Y * RayStepLength;

                if (prevInLens != InLens(nextX, nextY))
                {
                    Func<double, double, double> n = (double material, double waveLength) =>
                    {
                        return material + (2.4 * 10e-3) / Math.Pow(waveLength / 1000, 2);
                    };
                    path.AddLine((int)startX, (int)startY, (int)nextX, (int)nextY);
                    startX = nextX; startY = nextY;
                    if (prevX <= Fend(prevY) != nextX <= Fend(nextY))
                    {
                        double X1 = Fend(nextY - 0.3), X2 = Fend(nextY + 0.3);
                        double angle = Math.Atan2(0.6, (X2 - X1));
                        double newAngle = angleRad - angle;
                        newAngle = Math.Asin((prevInLens ? (n(LensRefractIndex, waveLength) / n(1, waveLength)) : (n(1, waveLength) / n(LensRefractIndex, waveLength))) * Math.Sin(newAngle));
                        if (double.IsNaN(newAngle)) {
                            if (AllowTotalReflect)
                            {
                                double critAngle = Math.Asin(n(1, waveLength) / n(LensRefractIndex, waveLength));
                                angleRad += (angleRad - angle < 0 ? -critAngle * 2 : critAngle * 2);
                                move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                                continue;
                            } else
                            {
                                angleRad = double.NaN;
                                break;
                            }
                        }
                        angleRad = newAngle + angle;
                        move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                    }
                    else if (prevX >= Fstart(prevY) != nextX >= Fstart(nextY))
                    {
                        double X1 = Fstart(nextY - 0.3), X2 = Fstart(nextY + 0.3);
                        double angle = Math.Atan2(0.6, (X2 - X1));
                        double newAngle = angleRad - angle;
                        newAngle = Math.Asin((prevInLens ? (n(LensRefractIndex, waveLength) / n(1, waveLength)) : (n(1, waveLength) / n(LensRefractIndex, waveLength))) * Math.Sin(newAngle));
                        if (double.IsNaN(newAngle)) {
                            if (AllowTotalReflect)
                            {
                                double critAngle = Math.Asin(n(1, waveLength) / n(LensRefractIndex, waveLength));
                                angleRad += (angleRad - angle < 0 ? -critAngle * 2 : critAngle * 2);
                                move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                                continue;
                            }
                            else
                            {
                                angleRad = double.NaN;
                                break;
                            }
                        }
                        angleRad = angle + newAngle;
                        move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                    }
                    else if (prevY >= (LensY - LensHeight / 2) != nextY >= (LensY - LensHeight / 2))
                    {
                        double newAngle = angleRad - 0.5 * Math.PI;
                        newAngle = Math.Asin((!prevInLens ? (n(LensRefractIndex, waveLength) / n(1, waveLength)) : (1 / n(LensRefractIndex, waveLength))) * Math.Sin(newAngle));
                        if (double.IsNaN(newAngle))
                        {
                            if (AllowTotalReflect)
                            {
                                double critAngle = Math.Asin(n(1, waveLength) / n(LensRefractIndex, waveLength));
                                angleRad += (angleRad - 0.5 * Math.PI < 0 ? -critAngle * 2 : critAngle * 2);
                                move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                                continue;
                            }
                            else
                            {
                                angleRad = double.NaN;
                                break;
                            }
                        }
                        angleRad = newAngle + 0.5 * Math.PI;
                        move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                    }
                    else if (prevY <= (LensY + LensHeight / 2) != nextY <= (LensY + LensHeight / 2))
                    {
                        double newAngle = angleRad - 0.5 * Math.PI;
                        newAngle = Math.Asin((!prevInLens ? (n(LensRefractIndex, waveLength) / n(1, waveLength)) : (n(1, waveLength) / n(LensRefractIndex, waveLength))) * Math.Sin(newAngle));
                        if (double.IsNaN(newAngle)) {
                            if (AllowTotalReflect)
                            {
                                double critAngle = Math.Asin(n(1, waveLength) / n(LensRefractIndex, waveLength));
                                angleRad += (angleRad - 0.5 * Math.PI < 0 ? -critAngle * 2 : critAngle * 2);
                                move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                                continue;
                            }
                            else
                            {
                                angleRad = double.NaN;
                                break;
                            }
                        }
                        angleRad = newAngle + 0.5 * Math.PI;
                        move_vector = (Math.Sin(angleRad), Math.Cos(angleRad));
                    }
                    prevInLens = InLens(nextX, nextY);
                }
            }
            if (double.IsNaN(angleRad))
            {
                g?.DrawPath(pen, path);
                return null;
            }

            path.AddLine((int)startX, (int)startY, (int)nextX, (int)nextY);
            try
            {
                g?.DrawPath(pen, path);
            }
            catch
            {
                return null;
            }

            int? result = (nextX >= ImageDistance) ? (int)nextY : null;
            if (DrawAfterExit && nextX >= ImageDistance)
            {
                startX = nextX; startY = nextY;
                nextX = field.Width;
                nextY = FindY(startX, nextX, startY, angleRad);
                g?.DrawLine(new(Color.FromArgb(pen.Color.A / 2, pen.Color.R, pen.Color.G, pen.Color.B), pen.Width),
                    (int)startX, (int)startY, (int)nextX, (int)nextY);
            }
            return result;
        }

        static double FindY(double startX, double endX, double startY, double angleRad)
        {
            (double X, double Y) = (Math.Sin(angleRad), Math.Cos(angleRad));
            return (startY - ((endX - startX) / X) * Y);
        }

        private void OpenSettings_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new Settings(this);
                settings.Show();
                openSettings.Text = "Показать настройки";
            } else
            {
                settings.BringToFront();
            }
        }
    }
}
