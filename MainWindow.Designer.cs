namespace OpticalAberration
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            field = new Panel();
            image = new Panel();
            openSettings = new Button();
            SuspendLayout();
            // 
            // field
            // 
            field.BackColor = Color.Black;
            field.BorderStyle = BorderStyle.Fixed3D;
            field.Location = new Point(12, 12);
            field.Name = "field";
            field.Size = new Size(788, 515);
            field.TabIndex = 0;
            // 
            // image
            // 
            image.BackColor = Color.Black;
            image.BorderStyle = BorderStyle.Fixed3D;
            image.Location = new Point(806, 12);
            image.Name = "image";
            image.Size = new Size(368, 515);
            image.TabIndex = 1;
            // 
            // openSettings
            // 
            openSettings.FlatStyle = FlatStyle.Flat;
            openSettings.Font = new Font("Comic Sans MS", 16F);
            openSettings.Location = new Point(437, 539);
            openSettings.Name = "openSettings";
            openSettings.Size = new Size(326, 54);
            openSettings.TabIndex = 2;
            openSettings.Text = "Открыть настройки";
            openSettings.UseVisualStyleBackColor = true;
            openSettings.Click += OpenSettings_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 603);
            Controls.Add(openSettings);
            Controls.Add(image);
            Controls.Add(field);
            DoubleBuffered = true;
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 200);
            Name = "MainWindow";
            Text = "Оптическая аберрация";
            ResumeLayout(false);
        }

        #endregion

        public Panel field;
        public Panel image;
        public Button openSettings;
    }
}
