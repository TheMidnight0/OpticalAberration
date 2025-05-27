namespace OpticalAberration
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RayCountBar = new TrackBar();
            RayCountBox = new TextBox();
            label1 = new Label();
            RainbowPatternBox = new CheckBox();
            label2 = new Label();
            LensRadiusLeftBox = new TextBox();
            LensRadiusLeftBar = new TrackBar();
            label3 = new Label();
            LensRadiusRightBox = new TextBox();
            LensRadiusRightBar = new TrackBar();
            label4 = new Label();
            ExitDistanceBox = new TextBox();
            ExitDistanceBar = new TrackBar();
            label5 = new Label();
            AngleBox = new TextBox();
            AngleBar = new TrackBar();
            label6 = new Label();
            ImageBlurStrengthBox = new TextBox();
            ImageBlurStrengthBar = new TrackBar();
            label7 = new Label();
            RayStrengthBox = new TextBox();
            RayStrengthBar = new TrackBar();
            DrawAfterExitBox = new CheckBox();
            label8 = new Label();
            LensHeightBox = new TextBox();
            LensHeightBar = new TrackBar();
            category1 = new Label();
            category2 = new Label();
            category3 = new Label();
            stopScroll = new Label();
            ((System.ComponentModel.ISupportInitialize)RayCountBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitDistanceBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngleBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBlurStrengthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RayStrengthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensHeightBar).BeginInit();
            SuspendLayout();
            // 
            // RayCountBar
            // 
            RayCountBar.AutoSize = false;
            RayCountBar.Location = new Point(17, 91);
            RayCountBar.Margin = new Padding(4);
            RayCountBar.Maximum = 2000;
            RayCountBar.Name = "RayCountBar";
            RayCountBar.Size = new Size(195, 35);
            RayCountBar.TabIndex = 0;
            RayCountBar.TickStyle = TickStyle.None;
            RayCountBar.Value = 50;
            RayCountBar.Scroll += RayCountBar_Scroll;
            // 
            // RayCountBox
            // 
            RayCountBox.Font = new Font("Comic Sans MS", 12F);
            RayCountBox.Location = new Point(220, 91);
            RayCountBox.Margin = new Padding(4);
            RayCountBox.MaxLength = 4;
            RayCountBox.Name = "RayCountBox";
            RayCountBox.Size = new Size(59, 35);
            RayCountBox.TabIndex = 1;
            RayCountBox.Text = "50";
            RayCountBox.TextChanged += RayCountBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 59);
            label1.Name = "label1";
            label1.Size = new Size(126, 28);
            label1.TabIndex = 2;
            label1.Text = "Количество";
            // 
            // RainbowPatternBox
            // 
            RainbowPatternBox.AutoSize = true;
            RainbowPatternBox.Location = new Point(32, 215);
            RainbowPatternBox.Name = "RainbowPatternBox";
            RainbowPatternBox.Size = new Size(210, 32);
            RainbowPatternBox.TabIndex = 3;
            RainbowPatternBox.Text = "Радужный паттерн";
            RainbowPatternBox.UseVisualStyleBackColor = true;
            RainbowPatternBox.CheckedChanged += RainbowPatternBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 343);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 6;
            label2.Text = "Левый радиус";
            // 
            // LensRadiusLeftBox
            // 
            LensRadiusLeftBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusLeftBox.Location = new Point(220, 375);
            LensRadiusLeftBox.Margin = new Padding(4);
            LensRadiusLeftBox.MaxLength = 3;
            LensRadiusLeftBox.Name = "LensRadiusLeftBox";
            LensRadiusLeftBox.Size = new Size(59, 35);
            LensRadiusLeftBox.TabIndex = 5;
            LensRadiusLeftBox.Text = "20";
            LensRadiusLeftBox.TextChanged += LensRadiusLeftbox_TextChanged;
            // 
            // LensRadiusLeftBar
            // 
            LensRadiusLeftBar.AutoSize = false;
            LensRadiusLeftBar.Location = new Point(17, 375);
            LensRadiusLeftBar.Margin = new Padding(4);
            LensRadiusLeftBar.Maximum = 60;
            LensRadiusLeftBar.Minimum = -60;
            LensRadiusLeftBar.Name = "LensRadiusLeftBar";
            LensRadiusLeftBar.Size = new Size(195, 35);
            LensRadiusLeftBar.TabIndex = 4;
            LensRadiusLeftBar.TickStyle = TickStyle.None;
            LensRadiusLeftBar.Value = 20;
            LensRadiusLeftBar.Scroll += LensRadiusLeftBar_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(317, 343);
            label3.Name = "label3";
            label3.Size = new Size(162, 28);
            label3.TabIndex = 9;
            label3.Text = "Правый радиус";
            // 
            // LensRadiusRightBox
            // 
            LensRadiusRightBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusRightBox.Location = new Point(521, 375);
            LensRadiusRightBox.Margin = new Padding(4);
            LensRadiusRightBox.MaxLength = 3;
            LensRadiusRightBox.Name = "LensRadiusRightBox";
            LensRadiusRightBox.Size = new Size(59, 35);
            LensRadiusRightBox.TabIndex = 8;
            LensRadiusRightBox.Text = "20";
            LensRadiusRightBox.TextChanged += LensRadiusRightBox_TextChanged;
            // 
            // LensRadiusRightBar
            // 
            LensRadiusRightBar.AutoSize = false;
            LensRadiusRightBar.Location = new Point(318, 375);
            LensRadiusRightBar.Margin = new Padding(4);
            LensRadiusRightBar.Maximum = 60;
            LensRadiusRightBar.Minimum = -60;
            LensRadiusRightBar.Name = "LensRadiusRightBar";
            LensRadiusRightBar.Size = new Size(195, 35);
            LensRadiusRightBar.TabIndex = 7;
            LensRadiusRightBar.TickStyle = TickStyle.None;
            LensRadiusRightBar.Value = 20;
            LensRadiusRightBar.Scroll += LensRadiusRightBar_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 582);
            label4.Name = "label4";
            label4.Size = new Size(279, 28);
            label4.TabIndex = 12;
            label4.Text = "Расстояние до изображения";
            // 
            // ExitDistanceBox
            // 
            ExitDistanceBox.Font = new Font("Comic Sans MS", 12F);
            ExitDistanceBox.Location = new Point(216, 614);
            ExitDistanceBox.Margin = new Padding(4);
            ExitDistanceBox.MaxLength = 3;
            ExitDistanceBox.Name = "ExitDistanceBox";
            ExitDistanceBox.Size = new Size(59, 35);
            ExitDistanceBox.TabIndex = 11;
            ExitDistanceBox.Text = "120";
            ExitDistanceBox.TextChanged += ExitDistanceBox_TextChanged;
            // 
            // ExitDistanceBar
            // 
            ExitDistanceBar.AutoSize = false;
            ExitDistanceBar.Location = new Point(13, 614);
            ExitDistanceBar.Margin = new Padding(4);
            ExitDistanceBar.Maximum = 460;
            ExitDistanceBar.Name = "ExitDistanceBar";
            ExitDistanceBar.Size = new Size(195, 35);
            ExitDistanceBar.TabIndex = 10;
            ExitDistanceBar.TickStyle = TickStyle.None;
            ExitDistanceBar.Value = 120;
            ExitDistanceBar.Scroll += ExitDistanceBar_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 130);
            label5.Name = "label5";
            label5.Size = new Size(171, 28);
            label5.TabIndex = 15;
            label5.Text = "Начальный угол";
            // 
            // AngleBox
            // 
            AngleBox.Font = new Font("Comic Sans MS", 12F);
            AngleBox.Location = new Point(220, 162);
            AngleBox.Margin = new Padding(4);
            AngleBox.MaxLength = 4;
            AngleBox.Name = "AngleBox";
            AngleBox.Size = new Size(59, 35);
            AngleBox.TabIndex = 14;
            AngleBox.Text = "0";
            AngleBox.TextChanged += AngleBox_TextChanged;
            // 
            // AngleBar
            // 
            AngleBar.AutoSize = false;
            AngleBar.Location = new Point(17, 162);
            AngleBar.Margin = new Padding(4);
            AngleBar.Maximum = 65;
            AngleBar.Minimum = -65;
            AngleBar.Name = "AngleBar";
            AngleBar.Size = new Size(195, 35);
            AngleBar.TabIndex = 13;
            AngleBar.TickStyle = TickStyle.None;
            AngleBar.Scroll += AngleBar_Scroll;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 582);
            label6.Name = "label6";
            label6.Size = new Size(236, 28);
            label6.TabIndex = 18;
            label6.Text = "Размытие изображения";
            // 
            // ImageBlurStrengthBox
            // 
            ImageBlurStrengthBox.Font = new Font("Comic Sans MS", 12F);
            ImageBlurStrengthBox.Location = new Point(521, 614);
            ImageBlurStrengthBox.Margin = new Padding(4);
            ImageBlurStrengthBox.MaxLength = 2;
            ImageBlurStrengthBox.Name = "ImageBlurStrengthBox";
            ImageBlurStrengthBox.Size = new Size(59, 35);
            ImageBlurStrengthBox.TabIndex = 17;
            ImageBlurStrengthBox.Text = "20";
            ImageBlurStrengthBox.TextChanged += ImageBlurStrengthBox_TextChanged;
            // 
            // ImageBlurStrengthBar
            // 
            ImageBlurStrengthBar.AutoSize = false;
            ImageBlurStrengthBar.Location = new Point(318, 614);
            ImageBlurStrengthBar.Margin = new Padding(4);
            ImageBlurStrengthBar.Maximum = 20;
            ImageBlurStrengthBar.Minimum = 1;
            ImageBlurStrengthBar.Name = "ImageBlurStrengthBar";
            ImageBlurStrengthBar.Size = new Size(195, 35);
            ImageBlurStrengthBar.TabIndex = 16;
            ImageBlurStrengthBar.TickStyle = TickStyle.None;
            ImageBlurStrengthBar.Value = 2;
            ImageBlurStrengthBar.Scroll += ImageBlurStrengthBar_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(317, 59);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 21;
            label7.Text = "Яркость";
            // 
            // RayStrengthBox
            // 
            RayStrengthBox.Font = new Font("Comic Sans MS", 12F);
            RayStrengthBox.Location = new Point(521, 91);
            RayStrengthBox.Margin = new Padding(4);
            RayStrengthBox.MaxLength = 3;
            RayStrengthBox.Name = "RayStrengthBox";
            RayStrengthBox.Size = new Size(59, 35);
            RayStrengthBox.TabIndex = 20;
            RayStrengthBox.Text = "100";
            RayStrengthBox.TextChanged += RayStrengthBox_TextChanged;
            // 
            // RayStrengthBar
            // 
            RayStrengthBar.AutoSize = false;
            RayStrengthBar.Location = new Point(318, 91);
            RayStrengthBar.Margin = new Padding(4);
            RayStrengthBar.Maximum = 255;
            RayStrengthBar.Minimum = 1;
            RayStrengthBar.Name = "RayStrengthBar";
            RayStrengthBar.Size = new Size(195, 35);
            RayStrengthBar.TabIndex = 19;
            RayStrengthBar.TickStyle = TickStyle.None;
            RayStrengthBar.Value = 100;
            RayStrengthBar.Scroll += RayStrengthBar_Scroll;
            // 
            // DrawAfterExitBox
            // 
            DrawAfterExitBox.AutoSize = true;
            DrawAfterExitBox.Location = new Point(295, 215);
            DrawAfterExitBox.Name = "DrawAfterExitBox";
            DrawAfterExitBox.Size = new Size(290, 32);
            DrawAfterExitBox.TabIndex = 22;
            DrawAfterExitBox.Text = "Рисовать за изображением";
            DrawAfterExitBox.UseVisualStyleBackColor = true;
            DrawAfterExitBox.CheckedChanged += DrawAfterExitBox_CheckedChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(16, 414);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 25;
            label8.Text = "Высота";
            // 
            // LensHeightBox
            // 
            LensHeightBox.Font = new Font("Comic Sans MS", 12F);
            LensHeightBox.Location = new Point(220, 446);
            LensHeightBox.Margin = new Padding(4);
            LensHeightBox.MaxLength = 3;
            LensHeightBox.Name = "LensHeightBox";
            LensHeightBox.Size = new Size(59, 35);
            LensHeightBox.TabIndex = 24;
            LensHeightBox.Text = "300";
            LensHeightBox.TextChanged += LensHeightBox_TextChanged;
            // 
            // LensHeightBar
            // 
            LensHeightBar.AutoSize = false;
            LensHeightBar.Location = new Point(17, 446);
            LensHeightBar.Margin = new Padding(4);
            LensHeightBar.Maximum = 515;
            LensHeightBar.Name = "LensHeightBar";
            LensHeightBar.Size = new Size(195, 35);
            LensHeightBar.TabIndex = 23;
            LensHeightBar.TickStyle = TickStyle.None;
            LensHeightBar.Value = 300;
            LensHeightBar.Scroll += LensHeightBar_Scroll;
            // 
            // category1
            // 
            category1.AutoSize = true;
            category1.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            category1.Location = new Point(251, 9);
            category1.Name = "category1";
            category1.Size = new Size(83, 38);
            category1.TabIndex = 26;
            category1.Text = "Лучи";
            // 
            // category2
            // 
            category2.AutoSize = true;
            category2.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            category2.Location = new Point(251, 275);
            category2.Name = "category2";
            category2.Size = new Size(96, 38);
            category2.TabIndex = 27;
            category2.Text = "Линза";
            // 
            // category3
            // 
            category3.AutoSize = true;
            category3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            category3.Location = new Point(200, 513);
            category3.Name = "category3";
            category3.Size = new Size(188, 38);
            category3.TabIndex = 28;
            category3.Text = "Изображение";
            // 
            // stopScroll
            // 
            stopScroll.AutoSize = true;
            stopScroll.Location = new Point(270, 679);
            stopScroll.Name = "stopScroll";
            stopScroll.Size = new Size(0, 28);
            stopScroll.TabIndex = 29;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(614, 594);
            Controls.Add(stopScroll);
            Controls.Add(category3);
            Controls.Add(category2);
            Controls.Add(category1);
            Controls.Add(label8);
            Controls.Add(LensHeightBox);
            Controls.Add(LensHeightBar);
            Controls.Add(DrawAfterExitBox);
            Controls.Add(label7);
            Controls.Add(RayStrengthBox);
            Controls.Add(RayStrengthBar);
            Controls.Add(label6);
            Controls.Add(ImageBlurStrengthBox);
            Controls.Add(ImageBlurStrengthBar);
            Controls.Add(label5);
            Controls.Add(AngleBox);
            Controls.Add(AngleBar);
            Controls.Add(label4);
            Controls.Add(ExitDistanceBox);
            Controls.Add(ExitDistanceBar);
            Controls.Add(label3);
            Controls.Add(LensRadiusRightBox);
            Controls.Add(LensRadiusRightBar);
            Controls.Add(label2);
            Controls.Add(LensRadiusLeftBox);
            Controls.Add(LensRadiusLeftBar);
            Controls.Add(RainbowPatternBox);
            Controls.Add(label1);
            Controls.Add(RayCountBox);
            Controls.Add(RayCountBar);
            Font = new Font("Comic Sans MS", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки модели";
            ((System.ComponentModel.ISupportInitialize)RayCountBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitDistanceBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngleBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBlurStrengthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RayStrengthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensHeightBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar RayCountBar;
        private TextBox RayCountBox;
        private Label label1;
        private CheckBox RainbowPatternBox;
        private Label label2;
        private TextBox LensRadiusLeftBox;
        private TrackBar LensRadiusLeftBar;
        private Label label3;
        private TextBox LensRadiusRightBox;
        private TrackBar LensRadiusRightBar;
        private Label label4;
        private TextBox ExitDistanceBox;
        private TrackBar ExitDistanceBar;
        private Label label5;
        private TextBox AngleBox;
        private TrackBar AngleBar;
        private Label label6;
        private TextBox ImageBlurStrengthBox;
        private TrackBar ImageBlurStrengthBar;
        private Label label7;
        private TextBox RayStrengthBox;
        private TrackBar RayStrengthBar;
        private CheckBox DrawAfterExitBox;
        private Label label8;
        private TextBox LensHeightBox;
        private TrackBar LensHeightBar;
        private Label category1;
        private Label category2;
        private Label category3;
        private Label stopScroll;
    }
}