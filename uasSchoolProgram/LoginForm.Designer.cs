﻿namespace uasSchoolProgram
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            UNameTb = new TextBox();
            PasswordTb = new TextBox();
            foreverButton1 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nohemi", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(180, 355);
            label1.Name = "label1";
            label1.Size = new Size(84, 14);
            label1.TabIndex = 5;
            label1.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nohemi", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(180, 414);
            label3.Name = "label3";
            label3.Size = new Size(85, 14);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // UNameTb
            // 
            UNameTb.Location = new Point(299, 346);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new Size(217, 23);
            UNameTb.TabIndex = 9;
            UNameTb.TextChanged += textBox1_TextChanged;
            // 
            // PasswordTb
            // 
            PasswordTb.Location = new Point(299, 411);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new Size(217, 23);
            PasswordTb.TabIndex = 10;
            // 
            // foreverButton1
            // 
            foreverButton1.BackColor = Color.Transparent;
            foreverButton1.BaseColor = Color.FromArgb(148, 115, 96);
            foreverButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foreverButton1.Location = new Point(396, 468);
            foreverButton1.Name = "foreverButton1";
            foreverButton1.Rounded = true;
            foreverButton1.Size = new Size(120, 40);
            foreverButton1.TabIndex = 13;
            foreverButton1.Text = "Login";
            foreverButton1.TextColor = Color.FromArgb(243, 243, 243);
            foreverButton1.Click += foreverButton1_Click;
            // 
            // foreverButton2
            // 
            foreverButton2.BackColor = Color.Transparent;
            foreverButton2.BaseColor = Color.FromArgb(148, 115, 96);
            foreverButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foreverButton2.Location = new Point(299, 468);
            foreverButton2.Name = "foreverButton2";
            foreverButton2.Rounded = true;
            foreverButton2.Size = new Size(80, 40);
            foreverButton2.TabIndex = 14;
            foreverButton2.Text = "Reset";
            foreverButton2.TextColor = Color.FromArgb(243, 243, 243);
            foreverButton2.Click += foreverButton2_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(748, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 208);
            ClientSize = new Size(810, 583);
            Controls.Add(pictureBox2);
            Controls.Add(foreverButton2);
            Controls.Add(foreverButton1);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private TextBox UNameTb;
        private TextBox PasswordTb;
        private ReaLTaiizor.Controls.ForeverButton foreverButton1;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private PictureBox pictureBox2;
    }
}