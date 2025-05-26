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
            ((System.ComponentModel.ISupportInitialize)RayCountBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ExitDistanceBar).BeginInit();
            SuspendLayout();
            // 
            // RayCountBar
            // 
            RayCountBar.AutoSize = false;
            RayCountBar.Location = new Point(9, 41);
            RayCountBar.Margin = new Padding(4);
            RayCountBar.Maximum = 1000;
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
            RayCountBox.Location = new Point(212, 41);
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
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 2;
            label1.Text = "Количество лучей";
            // 
            // RainbowPatternBox
            // 
            RainbowPatternBox.AutoSize = true;
            RainbowPatternBox.Location = new Point(19, 492);
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
            label2.Location = new Point(9, 118);
            label2.Name = "label2";
            label2.Size = new Size(217, 28);
            label2.TabIndex = 6;
            label2.Text = "Левый радиус линзы";
            // 
            // LensRadiusLeftBox
            // 
            LensRadiusLeftBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusLeftBox.Location = new Point(213, 150);
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
            LensRadiusLeftBar.Location = new Point(10, 150);
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
            label3.Location = new Point(10, 220);
            label3.Name = "label3";
            label3.Size = new Size(230, 28);
            label3.TabIndex = 9;
            label3.Text = "Правый радиус линзы";
            // 
            // LensRadiusRightBox
            // 
            LensRadiusRightBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusRightBox.Location = new Point(214, 252);
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
            LensRadiusRightBar.Location = new Point(11, 252);
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
            label4.Location = new Point(11, 316);
            label4.Name = "label4";
            label4.Size = new Size(279, 28);
            label4.TabIndex = 12;
            label4.Text = "Расстояние до изображения";
            // 
            // ExitDistanceBox
            // 
            ExitDistanceBox.Font = new Font("Comic Sans MS", 12F);
            ExitDistanceBox.Location = new Point(215, 348);
            ExitDistanceBox.Margin = new Padding(4);
            ExitDistanceBox.MaxLength = 3;
            ExitDistanceBox.Name = "ExitDistanceBox";
            ExitDistanceBox.Size = new Size(59, 35);
            ExitDistanceBox.TabIndex = 11;
            ExitDistanceBox.Text = "200";
            ExitDistanceBox.TextChanged += ExitDistanceBox_TextChanged;
            // 
            // ExitDistanceBar
            // 
            ExitDistanceBar.AutoSize = false;
            ExitDistanceBar.Location = new Point(12, 348);
            ExitDistanceBar.Margin = new Padding(4);
            ExitDistanceBar.Maximum = 440;
            ExitDistanceBar.Minimum = 50;
            ExitDistanceBar.Name = "ExitDistanceBar";
            ExitDistanceBar.Size = new Size(195, 35);
            ExitDistanceBar.TabIndex = 10;
            ExitDistanceBar.TickStyle = TickStyle.None;
            ExitDistanceBar.Value = 200;
            ExitDistanceBar.Scroll += ExitDistanceBar_Scroll;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 546);
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
            Margin = new Padding(4);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки модели";
            ((System.ComponentModel.ISupportInitialize)RayCountBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ExitDistanceBar).EndInit();
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
    }
}