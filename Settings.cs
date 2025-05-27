using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpticalAberration
{
    public partial class Settings : Form
    {
        readonly MainWindow main;
        bool lockRefresh = true;
        List<Label> categories = [];

        public Settings(MainWindow window)
        {
            InitializeComponent();
            categories.AddRange([
                category1, category2, category3
                ]);
            main = window;
            main.Resize += Main_Resize; ;
            Paint += Settings_Paint;

            SyncChanges();
            RayCountBox.Text = main.RayCount.ToString();
            LensRadiusLeftBox.Text = main.LensRadiusLeft.ToString();
            LensRadiusRightBox.Text = main.LensRadiusRight.ToString();
            ExitDistanceBox.Text = main.ExitDistance.ToString();
            ImageBlurStrengthBox.Text = main.ImageBlurStrength.ToString();
            AngleBox.Text = main.Angle.ToString();
            RayStrengthBox.Text = main.RayStrength.ToString();
            LensHeightBox.Text = main.LensHeight.ToString();
            RainbowPatternBox.Checked = main.RainbowPattern;
            DrawAfterExitBox.Checked = main.DrawAfterExit;
            lockRefresh = false;
        }

        private void Main_Resize(object? sender, EventArgs e)
        {
            SyncChanges();
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
            ExitDistanceBar.Maximum = main.field.Width * 2 / 3 - 60 - 5;
            ExitDistanceBar.Value = main.ExitDistance > ExitDistanceBar.Maximum ? ExitDistanceBar.Maximum : main.ExitDistance;
            ExitDistanceBox.Text = ExitDistanceBar.Value.ToString();

            LensHeightBar.Maximum = main.field.Height;
            LensHeightBar.Value = main.LensHeight > LensHeightBar.Maximum ? LensHeightBar.Maximum : main.LensHeight;
            LensHeightBox.Text = LensHeightBar.Value.ToString();
        }

        private async void RayCountBar_Scroll(object sender, EventArgs e)
        {
            RayCountBox.Text = RayCountBar.Value.ToString();
            main.RayCount = RayCountBar.Value;
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void RayCountBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RayCountBar.Value = int.Parse(RayCountBox.Text);
                main.RayCount = RayCountBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void RainbowPatternBox_CheckedChanged(object sender, EventArgs e)
        {
            main.RainbowPattern = RainbowPatternBox.Checked;
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void LensRadiusLeftBar_Scroll(object sender, EventArgs e)
        {
            main.LensRadiusLeft = LensRadiusLeftBar.Value;
            LensRadiusLeftBox.Text = LensRadiusLeftBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void LensRadiusLeftbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LensRadiusLeftBar.Value = int.Parse(LensRadiusLeftBox.Text);
                main.LensRadiusLeft = LensRadiusLeftBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void LensRadiusRightBar_Scroll(object sender, EventArgs e)
        {
            main.LensRadiusRight = LensRadiusRightBar.Value;
            LensRadiusRightBox.Text = LensRadiusRightBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void LensRadiusRightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LensRadiusRightBar.Value = int.Parse(LensRadiusRightBox.Text);
                main.LensRadiusRight = LensRadiusRightBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void ExitDistanceBar_Scroll(object sender, EventArgs e)
        {
            main.ExitDistance = ExitDistanceBar.Value;
            ExitDistanceBox.Text = ExitDistanceBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void ExitDistanceBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ExitDistanceBar.Value = int.Parse(ExitDistanceBox.Text);
                main.ExitDistance = ExitDistanceBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void AngleBar_Scroll(object sender, EventArgs e)
        {
            main.Angle = AngleBar.Value;
            AngleBox.Text = AngleBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void AngleBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                AngleBar.Value = int.Parse(AngleBox.Text);
                main.Angle = AngleBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void ImageBlurStrengthBar_Scroll(object sender, EventArgs e)
        {
            main.ImageBlurStrength = ImageBlurStrengthBar.Value;
            ImageBlurStrengthBox.Text = ImageBlurStrengthBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void ImageBlurStrengthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ImageBlurStrengthBar.Value = int.Parse(ImageBlurStrengthBox.Text);
                main.ImageBlurStrength = ImageBlurStrengthBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void RayStrengthBar_Scroll(object sender, EventArgs e)
        {
            main.RayStrength = RayStrengthBar.Value;
            RayStrengthBox.Text = RayStrengthBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void RayStrengthBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RayStrengthBar.Value = int.Parse(RayStrengthBox.Text);
                main.RayStrength = RayStrengthBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }

        private async void DrawAfterExitBox_CheckedChanged(object sender, EventArgs e)
        {
            main.DrawAfterExit = DrawAfterExitBox.Checked;
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void LensHeightBar_Scroll(object sender, EventArgs e)
        {
            main.LensHeight = LensHeightBar.Value;
            LensHeightBox.Text = LensHeightBar.Value.ToString();
            if (!lockRefresh) await Task.Run(main.field.Invalidate);
        }

        private async void LensHeightBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                LensHeightBar.Value = int.Parse(LensHeightBox.Text);
                main.LensHeight = LensHeightBar.Value;
                if (!lockRefresh) await Task.Run(main.field.Invalidate);
            }
            catch { }
        }
    }
}
