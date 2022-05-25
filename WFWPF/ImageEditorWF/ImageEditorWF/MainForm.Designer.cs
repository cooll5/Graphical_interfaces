namespace ImageEditorWF
{
    partial class MainForm
    {
      
        private System.ComponentModel.IContainer components = null;

  
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
            this.button_reset = new System.Windows.Forms.Button();
            this.button_rotate = new System.Windows.Forms.Button();
            this.label_contrast = new System.Windows.Forms.Label();
            this.trackBar_contrast = new System.Windows.Forms.TrackBar();
            this.label_brightness = new System.Windows.Forms.Label();
            this.trackBar_brightness = new System.Windows.Forms.TrackBar();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.button_loadImage = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_settings = new System.Windows.Forms.TabPage();
            this.tabPage_drawing = new System.Windows.Forms.TabPage();
            this.label_color = new System.Windows.Forms.Label();
            this.button_setColor = new System.Windows.Forms.Button();
            this.label_thikness = new System.Windows.Forms.Label();
            this.trackBar_thickness = new System.Windows.Forms.TrackBar();
            this.checkBox_drawing = new System.Windows.Forms.CheckBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage_settings.SuspendLayout();
            this.tabPage_drawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_thickness)).BeginInit();
            this.SuspendLayout();
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(9, 289);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(233, 46);
            this.button_reset.TabIndex = 5;
            this.button_reset.Text = "Back to original";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // button_rotate
            // 
            this.button_rotate.Location = new System.Drawing.Point(9, 16);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(233, 39);
            this.button_rotate.TabIndex = 4;
            this.button_rotate.Text = "Turn on 90°";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.button_rotate_Click);
            // 
            // label_contrast
            // 
            this.label_contrast.AutoSize = true;
            this.label_contrast.Location = new System.Drawing.Point(94, 185);
            this.label_contrast.Name = "label_contrast";
            this.label_contrast.Size = new System.Drawing.Size(49, 13);
            this.label_contrast.TabIndex = 3;
            this.label_contrast.Text = "Contrast:";
            // 
            // trackBar_contrast
            // 
            this.trackBar_contrast.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar_contrast.Location = new System.Drawing.Point(9, 201);
            this.trackBar_contrast.Name = "trackBar_contrast";
            this.trackBar_contrast.Size = new System.Drawing.Size(233, 45);
            this.trackBar_contrast.TabIndex = 2;
            this.trackBar_contrast.Scroll += new System.EventHandler(this.trackBar_contrast_Scroll);
            // 
            // label_brightness
            // 
            this.label_brightness.AutoSize = true;
            this.label_brightness.Location = new System.Drawing.Point(94, 87);
            this.label_brightness.Name = "label_brightness";
            this.label_brightness.Size = new System.Drawing.Size(59, 13);
            this.label_brightness.TabIndex = 1;
            this.label_brightness.Text = "Brightness:";
            // 
            // trackBar_brightness
            // 
            this.trackBar_brightness.BackColor = System.Drawing.SystemColors.GrayText;
            this.trackBar_brightness.Location = new System.Drawing.Point(9, 103);
            this.trackBar_brightness.Name = "trackBar_brightness";
            this.trackBar_brightness.Size = new System.Drawing.Size(233, 45);
            this.trackBar_brightness.TabIndex = 0;
            this.trackBar_brightness.Value = 10;
            this.trackBar_brightness.Scroll += new System.EventHandler(this.trackBar_brightness_Scroll);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox_image.Location = new System.Drawing.Point(12, 1);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(546, 426);
            this.pictureBox_image.TabIndex = 1;
            this.pictureBox_image.TabStop = false;
            this.pictureBox_image.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseDown);
            this.pictureBox_image.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseMove);
            this.pictureBox_image.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_image_MouseUp);
            // 
            // button_loadImage
            // 
            this.button_loadImage.Location = new System.Drawing.Point(564, 382);
            this.button_loadImage.Name = "button_loadImage";
            this.button_loadImage.Size = new System.Drawing.Size(130, 42);
            this.button_loadImage.TabIndex = 2;
            this.button_loadImage.Text = "Input photo";
            this.button_loadImage.UseVisualStyleBackColor = true;
            this.button_loadImage.Click += new System.EventHandler(this.button_loadImage_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(707, 382);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(119, 42);
            this.button_save.TabIndex = 3;
            this.button_save.Text = "Save photo";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_settings);
            this.tabControl.Controls.Add(this.tabPage_drawing);
            this.tabControl.Location = new System.Drawing.Point(564, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(264, 364);
            this.tabControl.TabIndex = 7;
            // 
            // tabPage_settings
            // 
            this.tabPage_settings.BackColor = System.Drawing.Color.Silver;
            this.tabPage_settings.Controls.Add(this.trackBar_brightness);
            this.tabPage_settings.Controls.Add(this.button_reset);
            this.tabPage_settings.Controls.Add(this.label_brightness);
            this.tabPage_settings.Controls.Add(this.button_rotate);
            this.tabPage_settings.Controls.Add(this.label_contrast);
            this.tabPage_settings.Controls.Add(this.trackBar_contrast);
            this.tabPage_settings.Location = new System.Drawing.Point(4, 22);
            this.tabPage_settings.Name = "tabPage_settings";
            this.tabPage_settings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_settings.Size = new System.Drawing.Size(256, 338);
            this.tabPage_settings.TabIndex = 0;
            this.tabPage_settings.Text = "Налаштування";
            // 
            // tabPage_drawing
            // 
            this.tabPage_drawing.BackColor = System.Drawing.Color.Silver;
            this.tabPage_drawing.Controls.Add(this.label_color);
            this.tabPage_drawing.Controls.Add(this.button_setColor);
            this.tabPage_drawing.Controls.Add(this.label_thikness);
            this.tabPage_drawing.Controls.Add(this.trackBar_thickness);
            this.tabPage_drawing.Controls.Add(this.checkBox_drawing);
            this.tabPage_drawing.Location = new System.Drawing.Point(4, 22);
            this.tabPage_drawing.Name = "tabPage_drawing";
            this.tabPage_drawing.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_drawing.Size = new System.Drawing.Size(256, 338);
            this.tabPage_drawing.TabIndex = 1;
            this.tabPage_drawing.Text = "Малювання";
            // 
            // label_color
            // 
            this.label_color.BackColor = System.Drawing.Color.Black;
            this.label_color.Location = new System.Drawing.Point(93, 128);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(86, 36);
            this.label_color.TabIndex = 4;
            // 
            // button_setColor
            // 
            this.button_setColor.Location = new System.Drawing.Point(55, 83);
            this.button_setColor.Name = "button_setColor";
            this.button_setColor.Size = new System.Drawing.Size(154, 42);
            this.button_setColor.TabIndex = 3;
            this.button_setColor.Text = "Choose a color";
            this.button_setColor.UseVisualStyleBackColor = true;
            this.button_setColor.Click += new System.EventHandler(this.button_setColor_Click);
            // 
            // label_thikness
            // 
            this.label_thikness.AutoSize = true;
            this.label_thikness.Location = new System.Drawing.Point(93, 206);
            this.label_thikness.Name = "label_thikness";
            this.label_thikness.Size = new System.Drawing.Size(75, 13);
            this.label_thikness.TabIndex = 2;
            this.label_thikness.Text = "Line thickness";
            this.label_thikness.Click += new System.EventHandler(this.label_thikness_Click);
            // 
            // trackBar_thickness
            // 
            this.trackBar_thickness.BackColor = System.Drawing.Color.Gray;
            this.trackBar_thickness.Location = new System.Drawing.Point(23, 222);
            this.trackBar_thickness.Name = "trackBar_thickness";
            this.trackBar_thickness.Size = new System.Drawing.Size(217, 45);
            this.trackBar_thickness.TabIndex = 1;
            this.trackBar_thickness.Scroll += new System.EventHandler(this.trackBar_thickness_Scroll);
            // 
            // checkBox_drawing
            // 
            this.checkBox_drawing.AutoSize = true;
            this.checkBox_drawing.Location = new System.Drawing.Point(83, 60);
            this.checkBox_drawing.Name = "checkBox_drawing";
            this.checkBox_drawing.Size = new System.Drawing.Size(96, 17);
            this.checkBox_drawing.TabIndex = 0;
            this.checkBox_drawing.Text = "Painting on/off";
            this.checkBox_drawing.UseVisualStyleBackColor = true;
            this.checkBox_drawing.CheckedChanged += new System.EventHandler(this.checkBox_drawing_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(840, 439);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_loadImage);
            this.Controls.Add(this.pictureBox_image);
            this.Name = "MainForm";
            this.Text = "Graphic editor";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage_settings.ResumeLayout(false);
            this.tabPage_settings.PerformLayout();
            this.tabPage_drawing.ResumeLayout(false);
            this.tabPage_drawing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_thickness)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.Button button_loadImage;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TrackBar trackBar_brightness;
        private System.Windows.Forms.TrackBar trackBar_contrast;
        private System.Windows.Forms.Label label_brightness;
        private System.Windows.Forms.Label label_contrast;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_settings;
        private System.Windows.Forms.TabPage tabPage_drawing;
        private System.Windows.Forms.CheckBox checkBox_drawing;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.Button button_setColor;
        private System.Windows.Forms.Label label_thikness;
        private System.Windows.Forms.TrackBar trackBar_thickness;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

