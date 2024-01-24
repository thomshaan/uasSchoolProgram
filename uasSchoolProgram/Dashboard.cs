using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace uasSchoolProgram
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            countStudent();
            countTeacher();
            countEvent();
            sumFees();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private void foreverButton4_Click(object sender, EventArgs e)
        {
            Events obj = new Events();
            obj.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void foreverButton1_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            obj.Show();
            this.Hide();

        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {
            Teachers obj = new Teachers();
            obj.Show();
            this.Hide();
        }

        private void foreverButton3_Click(object sender, EventArgs e)
        {
            Attendance obj = new Attendance();
            obj.Show();
            this.Hide();
        }

        private void foreverButton5_Click(object sender, EventArgs e)
        {
            Dashboard obj = new Dashboard();
            obj.Show();
            this.Hide();
        }

        private void foreverButton6_Click(object sender, EventArgs e)
        {
            Fees obj = new Fees();
            obj.Show();
            this.Hide();
        }

        private void foreverButton7_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void countStudent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from StudentTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countEvent()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from EventsTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            EventsNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void countTeacher()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from TeacherTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            TeacherNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void sumFees()
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Sum(Amt) from FeesTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            FinanceSum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            countStudent();
        }

        private void StNum_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void foreverButton8_Click(object sender, EventArgs e)
        {
            Class Obj = new Class();
            Obj.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from ClassTbl", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ClassNum.Text = dt.Rows[0][0].ToString();
            Con.Close();
        }
    }
}
