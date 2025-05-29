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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "Red" }, -1, Color.Empty, Color.Red, null);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "Orange" }, -1, Color.Empty, Color.Orange, null);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "Yellow" }, -1, Color.Empty, Color.Yellow, null);
            ListViewItem listViewItem4 = new ListViewItem(new string[] { "Green" }, -1, Color.Empty, Color.Green, null);
            ListViewItem listViewItem5 = new ListViewItem(new string[] { "Cyan" }, -1, Color.Empty, Color.Cyan, null);
            ListViewItem listViewItem6 = new ListViewItem(new string[] { "Blue" }, -1, Color.Empty, Color.Blue, null);
            ListViewItem listViewItem7 = new ListViewItem(new string[] { "Purple" }, -1, Color.Empty, Color.Purple, null);
            ListViewItem listViewItem8 = new ListViewItem(new string[] { "Violet" }, -1, Color.Empty, Color.Violet, null);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            RayCountBar = new TrackBar();
            RayCountBox = new TextBox();
            label1 = new Label();
            AllowTotalReflectBox = new CheckBox();
            label2 = new Label();
            LensRadiusRightBox = new TextBox();
            LensRadiusRightBar = new TrackBar();
            label3 = new Label();
            LensRadiusLeftBox = new TextBox();
            LensRadiusLeftBar = new TrackBar();
            label4 = new Label();
            ImageDistanceBox = new TextBox();
            ImageDistanceBar = new TrackBar();
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
            label9 = new Label();
            LensRefractIndexBox = new TextBox();
            LensRefractIndexBar = new TrackBar();
            label10 = new Label();
            LensThicknessBox = new TextBox();
            LensThicknessBar = new TrackBar();
            label11 = new Label();
            RayStepLengthBox = new TextBox();
            RayStepLengthBar = new TrackBar();
            LensRadiusLeftNegativeBox = new CheckBox();
            LensRadiusRightNegativeBox = new CheckBox();
            RayColorsPalette = new ListView();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)RayCountBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageDistanceBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AngleBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImageBlurStrengthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RayStrengthBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensHeightBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensRefractIndexBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LensThicknessBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RayStepLengthBar).BeginInit();
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
            // AllowTotalReflectBox
            // 
            AllowTotalReflectBox.AutoSize = true;
            AllowTotalReflectBox.Location = new Point(319, 253);
            AllowTotalReflectBox.Name = "AllowTotalReflectBox";
            AllowTotalReflectBox.Size = new Size(240, 32);
            AllowTotalReflectBox.TabIndex = 3;
            AllowTotalReflectBox.Text = "Разрешить отражение";
            AllowTotalReflectBox.UseVisualStyleBackColor = true;
            AllowTotalReflectBox.CheckedChanged += AllowTotalReflectBox_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 387);
            label2.Name = "label2";
            label2.Size = new Size(162, 28);
            label2.TabIndex = 6;
            label2.Text = "Правый радиус";
            // 
            // LensRadiusRightBox
            // 
            LensRadiusRightBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusRightBox.Location = new Point(522, 419);
            LensRadiusRightBox.Margin = new Padding(4);
            LensRadiusRightBox.MaxLength = 5;
            LensRadiusRightBox.Name = "LensRadiusRightBox";
            LensRadiusRightBox.Size = new Size(59, 35);
            LensRadiusRightBox.TabIndex = 5;
            LensRadiusRightBox.Text = "20";
            // 
            // LensRadiusRightBar
            // 
            LensRadiusRightBar.AutoSize = false;
            LensRadiusRightBar.Location = new Point(319, 419);
            LensRadiusRightBar.Margin = new Padding(4);
            LensRadiusRightBar.Maximum = 1000;
            LensRadiusRightBar.Name = "LensRadiusRightBar";
            LensRadiusRightBar.Size = new Size(195, 35);
            LensRadiusRightBar.TabIndex = 4;
            LensRadiusRightBar.TickStyle = TickStyle.None;
            LensRadiusRightBar.Value = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 387);
            label3.Name = "label3";
            label3.Size = new Size(149, 28);
            label3.TabIndex = 9;
            label3.Text = "Левый радиус";
            // 
            // LensRadiusLeftBox
            // 
            LensRadiusLeftBox.Font = new Font("Comic Sans MS", 12F);
            LensRadiusLeftBox.Location = new Point(221, 419);
            LensRadiusLeftBox.Margin = new Padding(4);
            LensRadiusLeftBox.MaxLength = 5;
            LensRadiusLeftBox.Name = "LensRadiusLeftBox";
            LensRadiusLeftBox.Size = new Size(59, 35);
            LensRadiusLeftBox.TabIndex = 8;
            LensRadiusLeftBox.Text = "20";
            // 
            // LensRadiusLeftBar
            // 
            LensRadiusLeftBar.AutoSize = false;
            LensRadiusLeftBar.Location = new Point(18, 419);
            LensRadiusLeftBar.Margin = new Padding(4);
            LensRadiusLeftBar.Maximum = 1000;
            LensRadiusLeftBar.Name = "LensRadiusLeftBar";
            LensRadiusLeftBar.Size = new Size(195, 35);
            LensRadiusLeftBar.TabIndex = 7;
            LensRadiusLeftBar.TickStyle = TickStyle.None;
            LensRadiusLeftBar.Value = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 705);
            label4.Name = "label4";
            label4.Size = new Size(279, 28);
            label4.TabIndex = 12;
            label4.Text = "Расстояние до изображения";
            // 
            // ImageDistanceBox
            // 
            ImageDistanceBox.Font = new Font("Comic Sans MS", 12F);
            ImageDistanceBox.Location = new Point(216, 737);
            ImageDistanceBox.Margin = new Padding(4);
            ImageDistanceBox.MaxLength = 3;
            ImageDistanceBox.Name = "ImageDistanceBox";
            ImageDistanceBox.Size = new Size(59, 35);
            ImageDistanceBox.TabIndex = 11;
            ImageDistanceBox.Text = "120";
            // 
            // ImageDistanceBar
            // 
            ImageDistanceBar.AutoSize = false;
            ImageDistanceBar.Location = new Point(13, 737);
            ImageDistanceBar.Margin = new Padding(4);
            ImageDistanceBar.Maximum = 460;
            ImageDistanceBar.Name = "ImageDistanceBar";
            ImageDistanceBar.Size = new Size(195, 35);
            ImageDistanceBar.TabIndex = 10;
            ImageDistanceBar.TickStyle = TickStyle.None;
            ImageDistanceBar.Value = 120;
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
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(317, 705);
            label6.Name = "label6";
            label6.Size = new Size(236, 28);
            label6.TabIndex = 18;
            label6.Text = "Размытие изображения";
            // 
            // ImageBlurStrengthBox
            // 
            ImageBlurStrengthBox.Font = new Font("Comic Sans MS", 12F);
            ImageBlurStrengthBox.Location = new Point(521, 737);
            ImageBlurStrengthBox.Margin = new Padding(4);
            ImageBlurStrengthBox.MaxLength = 2;
            ImageBlurStrengthBox.Name = "ImageBlurStrengthBox";
            ImageBlurStrengthBox.Size = new Size(59, 35);
            ImageBlurStrengthBox.TabIndex = 17;
            ImageBlurStrengthBox.Text = "20";
            // 
            // ImageBlurStrengthBar
            // 
            ImageBlurStrengthBar.AutoSize = false;
            ImageBlurStrengthBar.Location = new Point(318, 737);
            ImageBlurStrengthBar.Margin = new Padding(4);
            ImageBlurStrengthBar.Maximum = 20;
            ImageBlurStrengthBar.Minimum = 1;
            ImageBlurStrengthBar.Name = "ImageBlurStrengthBar";
            ImageBlurStrengthBar.Size = new Size(195, 35);
            ImageBlurStrengthBar.TabIndex = 16;
            ImageBlurStrengthBar.TickStyle = TickStyle.None;
            ImageBlurStrengthBar.Value = 2;
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
            // 
            // DrawAfterExitBox
            // 
            DrawAfterExitBox.AutoSize = true;
            DrawAfterExitBox.Location = new Point(291, 215);
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
            label8.Location = new Point(18, 458);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 25;
            label8.Text = "Высота";
            // 
            // LensHeightBox
            // 
            LensHeightBox.Font = new Font("Comic Sans MS", 12F);
            LensHeightBox.Location = new Point(222, 490);
            LensHeightBox.Margin = new Padding(4);
            LensHeightBox.MaxLength = 3;
            LensHeightBox.Name = "LensHeightBox";
            LensHeightBox.Size = new Size(59, 35);
            LensHeightBox.TabIndex = 24;
            LensHeightBox.Text = "300";
            // 
            // LensHeightBar
            // 
            LensHeightBar.AutoSize = false;
            LensHeightBar.Location = new Point(19, 490);
            LensHeightBar.Margin = new Padding(4);
            LensHeightBar.Maximum = 515;
            LensHeightBar.Name = "LensHeightBar";
            LensHeightBar.Size = new Size(195, 35);
            LensHeightBar.TabIndex = 23;
            LensHeightBar.TickStyle = TickStyle.None;
            LensHeightBar.Value = 300;
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
            category2.Location = new Point(251, 316);
            category2.Name = "category2";
            category2.Size = new Size(96, 38);
            category2.TabIndex = 27;
            category2.Text = "Линза";
            // 
            // category3
            // 
            category3.AutoSize = true;
            category3.Font = new Font("Comic Sans MS", 16F, FontStyle.Bold);
            category3.Location = new Point(200, 636);
            category3.Name = "category3";
            category3.Size = new Size(188, 38);
            category3.TabIndex = 28;
            category3.Text = "Изображение";
            // 
            // stopScroll
            // 
            stopScroll.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            stopScroll.AutoSize = true;
            stopScroll.Location = new Point(278, 804);
            stopScroll.Name = "stopScroll";
            stopScroll.Size = new Size(42, 28);
            stopScroll.TabIndex = 29;
            stopScroll.Text = "« »";
            stopScroll.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(317, 458);
            label9.Name = "label9";
            label9.Size = new Size(263, 28);
            label9.TabIndex = 32;
            label9.Text = "Показатель преломления";
            // 
            // LensRefractIndexBox
            // 
            LensRefractIndexBox.Font = new Font("Comic Sans MS", 12F);
            LensRefractIndexBox.Location = new Point(521, 490);
            LensRefractIndexBox.Margin = new Padding(4);
            LensRefractIndexBox.MaxLength = 4;
            LensRefractIndexBox.Name = "LensRefractIndexBox";
            LensRefractIndexBox.Size = new Size(59, 35);
            LensRefractIndexBox.TabIndex = 31;
            LensRefractIndexBox.Text = "1.5";
            // 
            // LensRefractIndexBar
            // 
            LensRefractIndexBar.AutoSize = false;
            LensRefractIndexBar.Location = new Point(318, 490);
            LensRefractIndexBar.Margin = new Padding(4);
            LensRefractIndexBar.Maximum = 500;
            LensRefractIndexBar.Minimum = 100;
            LensRefractIndexBar.Name = "LensRefractIndexBar";
            LensRefractIndexBar.Size = new Size(195, 35);
            LensRefractIndexBar.TabIndex = 30;
            LensRefractIndexBar.TickStyle = TickStyle.None;
            LensRefractIndexBar.Value = 150;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(16, 526);
            label10.Name = "label10";
            label10.Size = new Size(101, 28);
            label10.TabIndex = 35;
            label10.Text = "Толщина";
            // 
            // LensThicknessBox
            // 
            LensThicknessBox.Font = new Font("Comic Sans MS", 12F);
            LensThicknessBox.Location = new Point(220, 558);
            LensThicknessBox.Margin = new Padding(4);
            LensThicknessBox.MaxLength = 3;
            LensThicknessBox.Name = "LensThicknessBox";
            LensThicknessBox.Size = new Size(59, 35);
            LensThicknessBox.TabIndex = 34;
            LensThicknessBox.Text = "20";
            // 
            // LensThicknessBar
            // 
            LensThicknessBar.AutoSize = false;
            LensThicknessBar.Location = new Point(17, 558);
            LensThicknessBar.Margin = new Padding(4);
            LensThicknessBar.Maximum = 300;
            LensThicknessBar.Minimum = 1;
            LensThicknessBar.Name = "LensThicknessBar";
            LensThicknessBar.Size = new Size(195, 35);
            LensThicknessBar.TabIndex = 33;
            LensThicknessBar.TickStyle = TickStyle.None;
            LensThicknessBar.Value = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(317, 130);
            label11.Name = "label11";
            label11.Size = new Size(124, 28);
            label11.TabIndex = 38;
            label11.Text = "Длина шага";
            // 
            // RayStepLengthBox
            // 
            RayStepLengthBox.Font = new Font("Comic Sans MS", 12F);
            RayStepLengthBox.Location = new Point(521, 162);
            RayStepLengthBox.Margin = new Padding(4);
            RayStepLengthBox.MaxLength = 4;
            RayStepLengthBox.Name = "RayStepLengthBox";
            RayStepLengthBox.Size = new Size(59, 35);
            RayStepLengthBox.TabIndex = 37;
            RayStepLengthBox.Text = "0";
            // 
            // RayStepLengthBar
            // 
            RayStepLengthBar.AutoSize = false;
            RayStepLengthBar.Location = new Point(318, 162);
            RayStepLengthBar.Margin = new Padding(4);
            RayStepLengthBar.Maximum = 65;
            RayStepLengthBar.Minimum = -65;
            RayStepLengthBar.Name = "RayStepLengthBar";
            RayStepLengthBar.Size = new Size(195, 35);
            RayStepLengthBar.TabIndex = 36;
            RayStepLengthBar.TickStyle = TickStyle.None;
            // 
            // LensRadiusLeftNegativeBox
            // 
            LensRadiusLeftNegativeBox.AutoSize = true;
            LensRadiusLeftNegativeBox.Font = new Font("Comic Sans MS", 9F);
            LensRadiusLeftNegativeBox.Location = new Point(172, 392);
            LensRadiusLeftNegativeBox.Name = "LensRadiusLeftNegativeBox";
            LensRadiusLeftNegativeBox.Size = new Size(91, 24);
            LensRadiusLeftNegativeBox.TabIndex = 39;
            LensRadiusLeftNegativeBox.Text = "Негатив";
            LensRadiusLeftNegativeBox.UseVisualStyleBackColor = true;
            LensRadiusLeftNegativeBox.CheckedChanged += LensRadiusLeftNegativeBox_CheckedChanged;
            // 
            // LensRadiusRightNegativeBox
            // 
            LensRadiusRightNegativeBox.AutoSize = true;
            LensRadiusRightNegativeBox.Font = new Font("Comic Sans MS", 9F);
            LensRadiusRightNegativeBox.Location = new Point(486, 392);
            LensRadiusRightNegativeBox.Name = "LensRadiusRightNegativeBox";
            LensRadiusRightNegativeBox.Size = new Size(91, 24);
            LensRadiusRightNegativeBox.TabIndex = 40;
            LensRadiusRightNegativeBox.Text = "Негатив";
            LensRadiusRightNegativeBox.UseVisualStyleBackColor = true;
            LensRadiusRightNegativeBox.CheckedChanged += LensRadiusRightNegativeBox_CheckedChanged;
            // 
            // RayColorsPalette
            // 
            RayColorsPalette.Alignment = ListViewAlignment.Left;
            RayColorsPalette.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8 });
            RayColorsPalette.Location = new Point(16, 232);
            RayColorsPalette.MultiSelect = false;
            RayColorsPalette.Name = "RayColorsPalette";
            RayColorsPalette.OwnerDraw = true;
            RayColorsPalette.Size = new Size(262, 53);
            RayColorsPalette.TabIndex = 41;
            RayColorsPalette.UseCompatibleStateImageBehavior = false;
            RayColorsPalette.View = View.Tile;
            RayColorsPalette.DrawItem += RayColorsPalette_DrawItem;
            RayColorsPalette.Click += RayColorsPalette_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(19, 201);
            label12.Name = "label12";
            label12.Size = new Size(67, 28);
            label12.TabIndex = 42;
            label12.Text = "Цвета";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(614, 594);
            Controls.Add(label12);
            Controls.Add(RayColorsPalette);
            Controls.Add(LensRadiusRightNegativeBox);
            Controls.Add(LensRadiusLeftNegativeBox);
            Controls.Add(label11);
            Controls.Add(RayStepLengthBox);
            Controls.Add(RayStepLengthBar);
            Controls.Add(label10);
            Controls.Add(LensThicknessBox);
            Controls.Add(LensThicknessBar);
            Controls.Add(label9);
            Controls.Add(LensRefractIndexBox);
            Controls.Add(LensRefractIndexBar);
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
            Controls.Add(ImageDistanceBox);
            Controls.Add(ImageDistanceBar);
            Controls.Add(label3);
            Controls.Add(LensRadiusLeftBox);
            Controls.Add(LensRadiusLeftBar);
            Controls.Add(label2);
            Controls.Add(LensRadiusRightBox);
            Controls.Add(LensRadiusRightBar);
            Controls.Add(AllowTotalReflectBox);
            Controls.Add(label1);
            Controls.Add(RayCountBox);
            Controls.Add(RayCountBar);
            Font = new Font("Comic Sans MS", 12F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Settings";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Настройки модели";
            ((System.ComponentModel.ISupportInitialize)RayCountBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusRightBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRadiusLeftBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageDistanceBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)AngleBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImageBlurStrengthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RayStrengthBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensHeightBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensRefractIndexBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)LensThicknessBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)RayStepLengthBar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar RayCountBar;
        private TextBox RayCountBox;
        private Label label1;
        private CheckBox AllowTotalReflectBox;
        private Label label2;
        private TextBox LensRadiusRightBox;
        private TrackBar LensRadiusRightBar;
        private Label label3;
        private TextBox LensRadiusLeftBox;
        private TrackBar LensRadiusLeftBar;
        private Label label4;
        private TextBox ImageDistanceBox;
        private TrackBar ImageDistanceBar;
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
        private Label label9;
        private TextBox LensRefractIndexBox;
        private TrackBar LensRefractIndexBar;
        private Label label10;
        private TextBox LensThicknessBox;
        private TrackBar LensThicknessBar;
        private Label label11;
        private TextBox RayStepLengthBox;
        private TrackBar RayStepLengthBar;
        private CheckBox LensRadiusLeftNegativeBox;
        private CheckBox LensRadiusRightNegativeBox;
        private ListView RayColorsPalette;
        private Label label12;
    }
}