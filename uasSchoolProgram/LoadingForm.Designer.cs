namespace uasSchoolProgram
{
    partial class LoadingForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            myProgressBar = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // myProgressBar
            // 
            myProgressBar.Enabled = false;
            myProgressBar.ForeColor = SystemColors.ControlDark;
            myProgressBar.Location = new Point(164, 317);
            myProgressBar.Name = "myProgressBar";
            myProgressBar.RightToLeft = RightToLeft.Yes;
            myProgressBar.Size = new Size(486, 23);
            myProgressBar.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nohemi Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(363, 355);
            label1.Name = "label1";
            label1.Size = new Size(101, 11);
            label1.TabIndex = 1;
            label1.Text = "Loading Module ...";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nohemi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(297, 286);
            label2.Name = "label2";
            label2.Size = new Size(244, 22);
            label2.TabIndex = 2;
            label2.Text = "School Management";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.school_icon_png_14043;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(323, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // LoadingForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 208);
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(myProgressBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            Text = "Form1";
            Load += LoadingForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar myProgressBar;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}