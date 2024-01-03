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
            progressBar1=new ProgressBar();
            label1=new Label();
            label2=new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Enabled=false;
            progressBar1.Location=new Point(164, 317);
            progressBar1.Name="progressBar1";
            progressBar1.Size=new Size(486, 23);
            progressBar1.TabIndex=0;
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Location=new Point(349, 352);
            label1.Name="label1";
            label1.Size=new Size(106, 15);
            label1.TabIndex=1;
            label1.Text="Loading Module ...";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Plus Jakarta Sans", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(260, 39);
            label2.Name="label2";
            label2.Size=new Size(284, 38);
            label2.TabIndex=2;
            label2.Text="School Management V1";
            label2.TextAlign=ContentAlignment.MiddleCenter;
            label2.UseMnemonic=false;
            label2.Click+=label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ButtonHighlight;
            ClientSize=new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Name="Form1";
            Text="Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label label1;
        private Label label2;
    }
}