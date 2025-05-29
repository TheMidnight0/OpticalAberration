using System.Linq;
using System.Reflection;
using System.Resources;

namespace OpticalAberration
{
    public partial class Settings : Form
    {
        readonly MainWindow main;
        readonly List<Label> categories = [];
        bool lockRefresh = true;

        public Settings(MainWindow window)
        {
            InitializeComponent();
            categories.AddRange([
                category1, category2, category3
                ]);
            main = window;
            main.Resize += Main_Resize; ;
            Paint += Settings_Paint;
            FormClosed += Settings_FormClosed;

            LensRadiusLeftNegativeBox.Checked = main.LensRadiusLeft < 0;
            LensRadiusRightNegativeBox.Checked = main.LensRadiusRight < 0;
            _ = new InputPair(main, "LensRadiusLeft", LensRadiusLeftBar, LensRadiusLeftBox, val =>
            {
                return (main.LensHeight / 2 + 1 + val) * (LensRadiusLeftNegativeBox.Checked ? -1 : 1);
            }, var =>
            {
                LensRadiusLeftNegativeBox.Checked = var < 0;
                return (int)(Math.Abs(var) - (main.LensHeight / 2 + 1));
            }, 0, 1000);
            _ = new InputPair(main, "LensRadiusRight", LensRadiusRightBar, LensRadiusRightBox, val =>
            {
                return (main.LensHeight / 2 + 1 + val) * (LensRadiusRightNegativeBox.Checked ? -1 : 1);
            }, var =>
            {
                LensRadiusRightNegativeBox.Checked = var < 0;
                return (int)(Math.Abs(var) - (main.LensHeight / 2 + 1));
            }, 0, 1000);
            _ = new InputPair(main, "LensThickness", LensThicknessBar, LensThicknessBox, val => val, var => (int)var, 1, 300);
            _ = new InputPair(main, "LensHeight", LensHeightBar, LensHeightBox, val => val, var => (int)var, 50, 515);
            _ = new InputPair(main, "Angle", AngleBar, AngleBox, val => val, var => (int)var, -80, 80);
            _ = new InputPair(main, "LensRefractIndex", LensRefractIndexBar, LensRefractIndexBox, val => val / 100f, var => (int)(var * 100), 100, 500);
            _ = new InputPair(main, "RayCount", RayCountBar, RayCountBox, val => val, var => (int)var, 0, 1000);
            _ = new InputPair(main, "RayStrength", RayStrengthBar, RayStrengthBox, val => val, var => (int)var, 0, 255);
            _ = new InputPair(main, "RayStepLength", RayStepLengthBar, RayStepLengthBox, val => val / 10f, var => (int)(var * 10), 1, 100);
            _ = new InputPair(main, "ImageBlurStrength", ImageBlurStrengthBar, ImageBlurStrengthBox, val => val, var => (int)var, 1, 15);
            _ = new InputPair(main, "ImageDistance", ImageDistanceBar, ImageDistanceBox, val => val, var => (int)var, 0, main.field.Width);
            DrawAfterExitBox.Checked = main.DrawAfterExit;
            AllowTotalReflectBox.Checked = main.AllowTotalReflect;
            RayColorsPalette.TileSize = new Size(48, RayColorsPalette.Height - (SystemInformation.HorizontalScrollBarHeight + 4));
            SyncChanges();
            lockRefresh = false;
        }

        private void RayColorsPalette_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            Color textColor = Color.Black;
            e.Graphics.FillRectangle(new SolidBrush(e.Item.BackColor), e.Bounds);
            if (main.RayColors.Contains(e.Item.BackColor))
            {
                e.Graphics.DrawRectangle(new(Color.Blue, 2), e.Bounds);
                TextRenderer.DrawText(e.Graphics, "✓", RayColorsPalette.Font, e.Bounds,
                        Color.Black, Color.Empty,
                        TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
            else
            {
                e.Graphics.DrawRectangle(new(Color.DarkGray, 2), e.Bounds);
            }
        }

        private async void RayColorsPalette_Click(object sender, EventArgs e)
        {
            if (RayColorsPalette.SelectedItems.Count > 0)
            {
                if (main.RayColors.Contains(RayColorsPalette.SelectedItems[0].BackColor))
                {
                    main.RayColors.Remove(RayColorsPalette.SelectedItems[0].BackColor);
                }
                else
                {
                    main.RayColors.Add(RayColorsPalette.SelectedItems[0].BackColor);
                }
                RayColorsPalette.Invalidate();
                await Task.Run(main.field.Invalidate);
            }
        }

        private void Settings_FormClosed(object? sender, FormClosedEventArgs e)
        {
            main.openSettings.Text = "Открыть настройки";
        }

        private void Main_Resize(object? sender, EventArgs e)
        {
            if (sender != null && ((Control)sender).Height != 34) SyncChanges();
        }

        private void Settings_Paint(object? sender, PaintEventArgs e)
        {
            Bitmap bitmap = new(Width, Height);
            Graphics g = Graphics.FromImage(bitmap);
            foreach (var category in categories)
            {
                g.DrawLine(new(Color.Black, 2),
                new(0, category.Top + category.Height + 3),
                new(Width, category.Top + category.Height + 3));
            }
            e.Graphics.DrawImage(bitmap, Point.Empty);
        }

        private void SyncChanges()
        {
            ImageDistanceBar.Maximum = main.field.Width - 7;
            ImageDistanceBar.Minimum = (main.LensRadiusRight > 0) ? (main.LensRadiusRightCenter.X + main.LensRadiusRight) : (main.LensX + main.LensThickness / 2);
            ImageDistanceBox.Text = ImageDistanceBar.Value.ToString();

            LensHeightBar.Maximum = main.field.Height;
            LensHeightBox.Text = LensHeightBar.Value.ToString();
        }

        private async void DrawAfterExitBox_CheckedChanged(object sender, EventArgs e)
        {
            main.DrawAfterExit = DrawAfterExitBox.Checked;
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private void LensRadiusLeftNegativeBox_CheckedChanged(object sender, EventArgs e)
        {
            LensRadiusLeftBox.Text = (Math.Abs(main.LensRadiusLeft) * (LensRadiusLeftNegativeBox.Checked ? -1 : 1)).ToString();
        }

        private void LensRadiusRightNegativeBox_CheckedChanged(object sender, EventArgs e)
        {
            LensRadiusRightBox.Text = (Math.Abs(main.LensRadiusRight) * (LensRadiusRightNegativeBox.Checked ? -1 : 1)).ToString();
        }

        private async void AllowTotalReflectBox_CheckedChanged(object sender, EventArgs e)
        {
            main.AllowTotalReflect = AllowTotalReflectBox.Checked;
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        class InputPair
        {
            public object? Property
            {
                get
                {
                    Type var = window.GetType();
                    PropertyInfo? propinfo = var.GetProperty(propertyName);
                    return propinfo?.GetValue(window);
                }
                set
                {
                    Type var = window.GetType();
                    PropertyInfo? propinfo = var.GetProperty(propertyName);
                    propinfo?.SetValue(window, value);
                }
            }
            public TrackBar TrackBar { get; set; }
            public TextBox TextBox { get; set; }

            public int Minimum
            {
                get => TrackBar.Minimum;
                set
                {
                    TrackBar.Minimum = value; if (!loopBreak) Sync();
                }
            }
            public int Maximum
            {
                get => TrackBar.Maximum;
                set
                {
                    TrackBar.Maximum = value; if (!loopBreak) Sync();
                }
            }

            readonly Func<int, dynamic> Fvar;
            readonly Func<dynamic, int> Fval;
            readonly MainWindow window;
            readonly string propertyName;
            bool loopBreak = true;

            public InputPair(MainWindow main, string property, TrackBar trackBar, TextBox textBox, Func<int, dynamic> fvar, Func<dynamic, int> fval, int minimum, int maximum)
            {
                propertyName = property;
                window = main;
                TrackBar = trackBar;
                TextBox = textBox;
                Fvar = fvar;
                Fval = fval;
                Minimum = minimum;
                Maximum = maximum;
                TrackBar.Scroll += TrackBar_Scroll;
                TextBox.TextChanged += TextBox_TextChanged;
                Sync();
                loopBreak = false;
            }

            public void Sync()
            {
                if (Property != null)
                {
                    TrackBar.Value = Math.Max(Math.Min(Fval(Property), TrackBar.Maximum), TrackBar.Minimum);
                    Property = Fvar(TrackBar.Value);
                    TextBox.Text = Property.ToString();
                }
            }

            private void TrackBar_Scroll(object? sender, EventArgs e)
            {
                if (!loopBreak)
                {
                    loopBreak = true;
                    Property = Fvar(TrackBar.Value);
                    TextBox.Text = Property.ToString();
                    window.field.Invalidate();
                    loopBreak = false;
                }
            }

            private void TextBox_TextChanged(object? sender, EventArgs e)
            {
                if (!loopBreak)
                {
                    try
                    {
                        loopBreak = true;
                        TrackBar.Value = Fval(double.Parse(TextBox.Text));
                        Property = Fvar(TrackBar.Value);
                        window.field.Invalidate();
                        loopBreak = false;
                    }
                    catch { loopBreak = false; }
                }
            }
        }
    }
}
