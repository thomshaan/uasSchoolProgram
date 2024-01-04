namespace uasSchoolProgram
{
    partial class Student
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
            panel1=new Panel();
            pictureBox8=new PictureBox();
            label1=new Label();
            label2=new Label();
            pictureBox1=new PictureBox();
            pictureBox9=new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor=Color.FromArgb(161, 175, 160);
            panel1.Controls.Add(pictureBox8);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock=DockStyle.Top;
            panel1.Location=new Point(0, 0);
            panel1.Name="panel1";
            panel1.Size=new Size(895, 94);
            panel1.TabIndex=22;
            // 
            // pictureBox8
            // 
            pictureBox8.Location=new Point(811, 30);
            pictureBox8.Name="pictureBox8";
            pictureBox8.Size=new Size(50, 46);
            pictureBox8.TabIndex=20;
            pictureBox8.TabStop=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Plus Jakarta Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor=SystemColors.ButtonFace;
            label1.Location=new Point(124, 51);
            label1.Name="label1";
            label1.Size=new Size(96, 25);
            label1.TabIndex=7;
            label1.Text="Hello, user!";
            label1.TextAlign=ContentAlignment.MiddleCenter;
            label1.UseMnemonic=false;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Nohemi", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor=SystemColors.ButtonFace;
            label2.Location=new Point(124, 17);
            label2.Name="label2";
            label2.Size=new Size(157, 34);
            label2.TabIndex=6;
            label2.Text="Student";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            label2.UseMnemonic=false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage=Properties.Resources.school_icon_png_14043;
            pictureBox1.Image=Properties.Resources.school_icon_png_14043;
            pictureBox1.Location=new Point(22, 14);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(67, 62);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=5;
            pictureBox1.TabStop=false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor=Color.FromArgb(148, 115, 96);
            pictureBox9.BorderStyle=BorderStyle.FixedSingle;
            pictureBox9.Dock=DockStyle.Left;
            pictureBox9.Location=new Point(0, 94);
            pictureBox9.Name="pictureBox9";
            pictureBox9.Size=new Size(185, 518);
            pictureBox9.TabIndex=23;
            pictureBox9.TabStop=false;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(247, 236, 208);
            ClientSize=new Size(895, 612);
            Controls.Add(pictureBox9);
            Controls.Add(panel1);
            FormBorderStyle=FormBorderStyle.None;
            Name="Form1";
            Text="Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox8;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
    }
}