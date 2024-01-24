using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uasSchoolProgram
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
            FillStudId();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayFees()
        {
            Con.Open();
            string Query = "Select * from FeesTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StdIdCb.ValueMember = "StId";
            StdIdCb.DataSource = dt;

            Con.Close();
        }

        private void GetStudName()
        {
            Con.Open();
            SqlCommand Cmd = new SqlCommand("select * from StudentTbl where StId=@SID", Con);
            Cmd.Parameters.AddWithValue("@SID", StdIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(Cmd);
            sda.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();
                AmountTb.Text = dr["StFees"].ToString();
            }

            Con.Close();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //UI
        private void foreverButton2_Click(object sender, EventArgs e)
        {
            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton1_Click(object sender, EventArgs e)
        {
        }

        private void foreverButton3_Click(object sender, EventArgs e)
        {
            Attendance Obj = new Attendance();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton4_Click(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton5_Click(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton6_Click(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton7_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton5_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }
        private void hopeButton3_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            AmountTb.Text = "";
            StNameTb.Text = "";
            StdIdCb.SelectedIndex = -1;
        }

        private void hopeButton4_Click(object sender, EventArgs e)
        {
            string paymentPeriod;
            paymentPeriod = PeriodDate.Value.Month.ToString() + "/" + PeriodDate.Value.Year.ToString();
            Con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from FeesTbl where StId = '" + StdIdCb.SelectedValue.ToString() + "' and Month = '" + paymentPeriod.ToString() + "'", Con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString()=="1")
            {
                MessageBox.Show("There is No Due for this Month");
            }
            else
            {


                SqlCommand cmd = new SqlCommand("insert into FeesTbl(StId,StName,Month,Amt) values (@SId, @SName, @SMonth, @SAmt)", Con);
                cmd.Parameters.AddWithValue("@SId", StdIdCb.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                cmd.Parameters.AddWithValue("@SMonth", paymentPeriod);
                cmd.Parameters.AddWithValue("@SAmt", AmountTb.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Fees Successfully Paid");

            }
            Con.Close();
            DisplayFees();
            Reset();


        }

        private void foreverButton1_Click_1(object sender, EventArgs e)
        {
            Student Obj = new Student();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton2_Click_1(object sender, EventArgs e)
        {
            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton3_Click_1(object sender, EventArgs e)
        {
            Attendance Obj = new Attendance();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton4_Click_1(object sender, EventArgs e)
        {
            Events Obj = new Events();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton6_Click_1(object sender, EventArgs e)
        {
            Fees Obj = new Fees();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton7_Click_1(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void FeesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void foreverButton8_Click(object sender, EventArgs e)
        {
            Class Obj = new Class();
            Obj.Show();
            this.Hide();
        }
    }
}
