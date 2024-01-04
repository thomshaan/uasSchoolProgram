namespace uasSchoolProgram
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
            pictureBox1=new PictureBox();
            label2=new Label();
            label1=new Label();
            label3=new Label();
            textBox1=new TextBox();
            textBox2=new TextBox();
            button1=new Button();
            button2=new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage=Properties.Resources.school_icon_png_14043;
            pictureBox1.Image=Properties.Resources.school_icon_png_14043;
            pictureBox1.Location=new Point(299, 73);
            pictureBox1.Name="pictureBox1";
            pictureBox1.Size=new Size(189, 185);
            pictureBox1.SizeMode=PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex=7;
            pictureBox1.TabStop=false;
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Nohemi", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(272, 284);
            label2.Name="label2";
            label2.Size=new Size(244, 22);
            label2.TabIndex=6;
            label2.Text="School Management";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            label2.UseMnemonic=false;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Nohemi", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(180, 355);
            label1.Name="label1";
            label1.Size=new Size(84, 14);
            label1.TabIndex=5;
            label1.Text="Username";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Nohemi", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(180, 414);
            label3.Name="label3";
            label3.Size=new Size(85, 14);
            label3.TabIndex=8;
            label3.Text="Password";
            // 
            // textBox1
            // 
            textBox1.Location=new Point(299, 346);
            textBox1.Name="textBox1";
            textBox1.Size=new Size(217, 23);
            textBox1.TabIndex=9;
            // 
            // textBox2
            // 
            textBox2.Location=new Point(299, 411);
            textBox2.Name="textBox2";
            textBox2.Size=new Size(217, 23);
            textBox2.TabIndex=10;
            // 
            // button1
            // 
            button1.Location=new Point(400, 472);
            button1.Name="button1";
            button1.Size=new Size(116, 41);
            button1.TabIndex=11;
            button1.Text="Login";
            button1.UseVisualStyleBackColor=true;
            button1.Click+=button1_Click;
            // 
            // button2
            // 
            button2.Location=new Point(299, 472);
            button2.Name="button2";
            button2.Size=new Size(62, 41);
            button2.TabIndex=12;
            button2.Text="Reset";
            button2.UseVisualStyleBackColor=true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=Color.FromArgb(247, 236, 208);
            ClientSize=new Size(810, 583);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle=FormBorderStyle.None;
            Name="LoginForm";
            Text="Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
    }
}