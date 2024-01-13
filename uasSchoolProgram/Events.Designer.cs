namespace uasSchoolProgram
{
    partial class Events
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Events));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            EDurationTb = new TextBox();
            label7 = new Label();
            EDate = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            EDescTb = new TextBox();
            BackBtn = new ReaLTaiizor.Controls.HopeButton();
            DeleteBtn = new ReaLTaiizor.Controls.HopeButton();
            EditBtn = new ReaLTaiizor.Controls.HopeButton();
            AddBtn = new ReaLTaiizor.Controls.HopeButton();
            Fees = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton5 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton4 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton3 = new ReaLTaiizor.Controls.ForeverButton();
            Students = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton2 = new ReaLTaiizor.Controls.ForeverButton();
            foreverButton7 = new ReaLTaiizor.Controls.ForeverButton();
            EventsDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EventsDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(161, 175, 160);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 94);
            panel1.TabIndex = 23;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(829, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 53);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Plus Jakarta Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(124, 51);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 7;
            label1.Text = "Hello, user!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nohemi", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(124, 17);
            label2.Name = "label2";
            label2.Size = new Size(135, 34);
            label2.TabIndex = 6;
            label2.Text = "Events";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.UseMnemonic = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.school_icon_png_14043;
            pictureBox1.Image = Properties.Resources.school_icon_png_14043;
            pictureBox1.Location = new Point(22, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(148, 115, 96);
            pictureBox9.BorderStyle = BorderStyle.FixedSingle;
            pictureBox9.Dock = DockStyle.Left;
            pictureBox9.Location = new Point(0, 94);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(185, 529);
            pictureBox9.TabIndex = 24;
            pictureBox9.TabStop = false;
            // 
            // EDurationTb
            // 
            EDurationTb.Location = new Point(690, 125);
            EDurationTb.Multiline = true;
            EDurationTb.Name = "EDurationTb";
            EDurationTb.Size = new Size(165, 57);
            EDurationTb.TabIndex = 101;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Plus Jakarta Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(553, 125);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 100;
            label7.Text = "Duration (Hours)";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.UseMnemonic = false;
            // 
            // EDate
            // 
            EDate.Location = new Point(353, 216);
            EDate.Name = "EDate";
            EDate.Size = new Size(160, 23);
            EDate.TabIndex = 99;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Plus Jakarta Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(259, 214);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 98;
            label6.Text = "Dates";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.UseMnemonic = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Plus Jakarta Sans", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(259, 125);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 97;
            label5.Text = "Events";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.UseMnemonic = false;
            // 
            // EDescTb
            // 
            EDescTb.Location = new Point(353, 125);
            EDescTb.Multiline = true;
            EDescTb.Name = "EDescTb";
            EDescTb.Size = new Size(160, 57);
            EDescTb.TabIndex = 96;
            // 
            // BackBtn
            // 
            BackBtn.BorderColor = Color.FromArgb(220, 223, 230);
            BackBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            BackBtn.DangerColor = Color.FromArgb(245, 108, 108);
            BackBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            BackBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BackBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            BackBtn.InfoColor = Color.FromArgb(144, 147, 153);
            BackBtn.Location = new Point(697, 287);
            BackBtn.Name = "BackBtn";
            BackBtn.PrimaryColor = Color.FromArgb(148, 115, 96);
            BackBtn.Size = new Size(108, 28);
            BackBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            BackBtn.TabIndex = 93;
            BackBtn.Text = "Back";
            BackBtn.TextColor = Color.White;
            BackBtn.WarningColor = Color.FromArgb(230, 162, 60);
            BackBtn.Click += BackBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.BorderColor = Color.FromArgb(220, 223, 230);
            DeleteBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            DeleteBtn.DangerColor = Color.FromArgb(245, 108, 108);
            DeleteBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            DeleteBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            DeleteBtn.InfoColor = Color.FromArgb(144, 147, 153);
            DeleteBtn.Location = new Point(259, 287);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.PrimaryColor = Color.FromArgb(148, 115, 96);
            DeleteBtn.Size = new Size(108, 28);
            DeleteBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            DeleteBtn.TabIndex = 92;
            DeleteBtn.Text = "Delete";
            DeleteBtn.TextColor = Color.White;
            DeleteBtn.WarningColor = Color.FromArgb(230, 162, 60);
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.BorderColor = Color.FromArgb(220, 223, 230);
            EditBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            EditBtn.DangerColor = Color.FromArgb(245, 108, 108);
            EditBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            EditBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EditBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            EditBtn.InfoColor = Color.FromArgb(144, 147, 153);
            EditBtn.Location = new Point(405, 287);
            EditBtn.Name = "EditBtn";
            EditBtn.PrimaryColor = Color.FromArgb(148, 115, 96);
            EditBtn.Size = new Size(108, 28);
            EditBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            EditBtn.TabIndex = 91;
            EditBtn.Text = "Edit";
            EditBtn.TextColor = Color.White;
            EditBtn.WarningColor = Color.FromArgb(230, 162, 60);
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BorderColor = Color.FromArgb(220, 223, 230);
            AddBtn.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            AddBtn.DangerColor = Color.FromArgb(245, 108, 108);
            AddBtn.DefaultColor = Color.FromArgb(255, 255, 255);
            AddBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AddBtn.HoverTextColor = Color.FromArgb(48, 49, 51);
            AddBtn.InfoColor = Color.FromArgb(144, 147, 153);
            AddBtn.Location = new Point(553, 287);
            AddBtn.Name = "AddBtn";
            AddBtn.PrimaryColor = Color.FromArgb(255, 128, 0);
            AddBtn.Size = new Size(108, 28);
            AddBtn.SuccessColor = Color.FromArgb(103, 194, 58);
            AddBtn.TabIndex = 90;
            AddBtn.Text = "Add";
            AddBtn.TextColor = Color.White;
            AddBtn.WarningColor = Color.FromArgb(230, 162, 60);
            AddBtn.Click += AddBtn_Click;
            // 
            // Fees
            // 
            Fees.BackColor = Color.Transparent;
            Fees.BackgroundImageLayout = ImageLayout.None;
            Fees.BaseColor = Color.FromArgb(247, 236, 208);
            Fees.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Fees.Location = new Point(0, 367);
            Fees.Name = "Fees";
            Fees.Rounded = false;
            Fees.Size = new Size(185, 45);
            Fees.TabIndex = 88;
            Fees.Text = "Fees";
            Fees.TextColor = Color.FromArgb(148, 115, 96);
            Fees.Click += Fees_Click;
            // 
            // foreverButton5
            // 
            foreverButton5.BackColor = Color.Transparent;
            foreverButton5.BackgroundImageLayout = ImageLayout.None;
            foreverButton5.BaseColor = Color.FromArgb(247, 236, 208);
            foreverButton5.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton5.Location = new Point(0, 316);
            foreverButton5.Name = "foreverButton5";
            foreverButton5.Rounded = false;
            foreverButton5.Size = new Size(185, 45);
            foreverButton5.TabIndex = 87;
            foreverButton5.Text = "Dashboards";
            foreverButton5.TextColor = Color.FromArgb(148, 115, 96);
            foreverButton5.Click += foreverButton5_Click;
            // 
            // foreverButton4
            // 
            foreverButton4.BackColor = Color.Transparent;
            foreverButton4.BackgroundImageLayout = ImageLayout.None;
            foreverButton4.BaseColor = Color.FromArgb(247, 236, 208);
            foreverButton4.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton4.Location = new Point(0, 265);
            foreverButton4.Name = "foreverButton4";
            foreverButton4.Rounded = false;
            foreverButton4.Size = new Size(185, 45);
            foreverButton4.TabIndex = 86;
            foreverButton4.Text = "Events";
            foreverButton4.TextColor = Color.FromArgb(148, 115, 96);
            foreverButton4.Click += foreverButton4_Click;
            // 
            // foreverButton3
            // 
            foreverButton3.BackColor = Color.Transparent;
            foreverButton3.BackgroundImageLayout = ImageLayout.None;
            foreverButton3.BaseColor = Color.FromArgb(247, 236, 208);
            foreverButton3.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton3.Location = new Point(0, 214);
            foreverButton3.Name = "foreverButton3";
            foreverButton3.Rounded = false;
            foreverButton3.Size = new Size(185, 45);
            foreverButton3.TabIndex = 85;
            foreverButton3.Text = "Attendance";
            foreverButton3.TextColor = Color.FromArgb(148, 115, 96);
            foreverButton3.Click += foreverButton3_Click;
            // 
            // Students
            // 
            Students.BackColor = Color.Transparent;
            Students.BackgroundImageLayout = ImageLayout.None;
            Students.BaseColor = Color.FromArgb(247, 236, 208);
            Students.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Students.Location = new Point(0, 112);
            Students.Name = "Students";
            Students.Rounded = false;
            Students.Size = new Size(185, 45);
            Students.TabIndex = 83;
            Students.Text = "Students";
            Students.TextColor = Color.FromArgb(148, 115, 96);
            Students.Click += foreverButton1_Click;
            // 
            // foreverButton2
            // 
            foreverButton2.BackColor = Color.Transparent;
            foreverButton2.BackgroundImageLayout = ImageLayout.None;
            foreverButton2.BaseColor = Color.FromArgb(247, 236, 208);
            foreverButton2.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton2.Location = new Point(0, 163);
            foreverButton2.Name = "foreverButton2";
            foreverButton2.Rounded = false;
            foreverButton2.Size = new Size(185, 45);
            foreverButton2.TabIndex = 84;
            foreverButton2.Text = "Teachers";
            foreverButton2.TextColor = Color.FromArgb(148, 115, 96);
            foreverButton2.Click += foreverButton2_Click;
            // 
            // foreverButton7
            // 
            foreverButton7.BackColor = Color.Transparent;
            foreverButton7.BackgroundImageLayout = ImageLayout.None;
            foreverButton7.BaseColor = Color.FromArgb(247, 236, 208);
            foreverButton7.Font = new Font("Plus Jakarta Sans SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            foreverButton7.Location = new Point(0, 418);
            foreverButton7.Name = "foreverButton7";
            foreverButton7.Rounded = false;
            foreverButton7.Size = new Size(185, 45);
            foreverButton7.TabIndex = 102;
            foreverButton7.Text = "Main Menu";
            foreverButton7.TextColor = Color.FromArgb(148, 115, 96);
            foreverButton7.Click += foreverButton7_Click;
            // 
            // EventsDGV
            // 
            EventsDGV.AllowUserToAddRows = false;
            EventsDGV.AllowUserToDeleteRows = false;
            EventsDGV.BackgroundColor = Color.FromArgb(148, 115, 96);
            EventsDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            EventsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            EventsDGV.GridColor = SystemColors.ButtonFace;
            EventsDGV.Location = new Point(223, 341);
            EventsDGV.Name = "EventsDGV";
            EventsDGV.ReadOnly = true;
            EventsDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            EventsDGV.RowTemplate.Height = 25;
            EventsDGV.Size = new Size(632, 256);
            EventsDGV.TabIndex = 103;
            EventsDGV.CellContentClick += EventsDGV_CellContentClick;
            // 
            // Events
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 236, 208);
            ClientSize = new Size(900, 623);
            Controls.Add(EventsDGV);
            Controls.Add(foreverButton7);
            Controls.Add(EDurationTb);
            Controls.Add(label7);
            Controls.Add(EDate);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(EDescTb);
            Controls.Add(BackBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(Fees);
            Controls.Add(foreverButton5);
            Controls.Add(foreverButton4);
            Controls.Add(foreverButton3);
            Controls.Add(Students);
            Controls.Add(foreverButton2);
            Controls.Add(pictureBox9);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Events";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)EventsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox9;
        private TextBox EDurationTb;
        private Label label7;
        private DateTimePicker EDate;
        private Label label6;
        private Label label5;
        private TextBox EDescTb;
        private ReaLTaiizor.Controls.HopeButton BackBtn;
        private ReaLTaiizor.Controls.HopeButton DeleteBtn;
        private ReaLTaiizor.Controls.HopeButton EditBtn;
        private ReaLTaiizor.Controls.HopeButton AddBtn;
        private ReaLTaiizor.Controls.ForeverButton Fees;
        private ReaLTaiizor.Controls.ForeverButton foreverButton5;
        private ReaLTaiizor.Controls.ForeverButton foreverButton4;
        private ReaLTaiizor.Controls.ForeverButton foreverButton3;
        private ReaLTaiizor.Controls.ForeverButton Students;
        private ReaLTaiizor.Controls.ForeverButton foreverButton2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.ForeverButton foreverButton7;
        private DataGridView EventsDGV;
    }
}