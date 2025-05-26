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

        public Settings(MainWindow window)
        {
            InitializeComponent();
            main = window;

            RayCountBox.Text = main.RayCount.ToString();
            LensRadiusLeftBox.Text = main.LensRadiusLeft.ToString();
            LensRadiusRightBox.Text = main.LensRadiusRight.ToString();
            ExitDistanceBox.Text = main.ExitDistance.ToString();
            RainbowPatternBox.Checked = main.RainbowPattern;
            lockRefresh = false;
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
    }
}
