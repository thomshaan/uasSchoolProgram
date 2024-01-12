﻿namespace uasSchoolProgram
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
            progressBar1 = new ProgressBar();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Enabled = false;
            progressBar1.ForeColor = SystemColors.ControlDark;
            progressBar1.Location = new Point(164, 317);
            progressBar1.Name = "progressBar1";
            progressBar1.RightToLeft = RightToLeft.Yes;
            progressBar1.Size = new Size(486, 23);
            progressBar1.TabIndex = 0;
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
            pictureBox1.Image = Properties.Resources.school_icon_png_14043;
            pictureBox1.Location = new Point(323, 79);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(189, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
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
            Controls.Add(progressBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadingForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
    }
}