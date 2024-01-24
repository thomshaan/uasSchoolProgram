using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using MySqlX.XDevAPI.Relational;


namespace uasSchoolProgram
{
    public partial class Student : Form
    {
        int Key = 0;
        public Student()
        {
            InitializeComponent();
            DisplayStudent();
            Reset();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DisplayStudent()
        {
            Con.Open();
            string Query = "Select * from StudentTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            StudentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == ""||FeesTb.Text =="" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into StudentTbl(StName,StGen,StDOB,StClass,StFees,StAdd) values (@Sname,@SGen,@SDob,@SClass,@SFees,@SAdd)", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Added");
                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Reset()
        {

            Key = 0;
            StNameTb.Text = "";
            FeesTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;

        }




        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == ""||FeesTb.Text =="" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTbl set StName=@Sname, StGen=@SGen, StDOB=@SDob, StClass=@SClass, StFees = @SFees, StAdd=@SAdd where StId=@StID ", Con);
                    cmd.Parameters.AddWithValue("@Sname", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("StID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void StudentDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < StudentDGV.Rows.Count)
            {
                DataGridViewRow row = StudentDGV.Rows[e.RowIndex];

                StNameTb.Text = row.Cells[1].Value.ToString();
                StGenCb.SelectedItem = row.Cells[2].Value.ToString();
                DOBPicker.Text = row.Cells[3].Value.ToString();
                ClassCb.SelectedItem = row.Cells[4].Value.ToString();
                FeesTb.Text = row.Cells[5].Value.ToString();
                AddressTb.Text = row.Cells[6].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value);
            }

            if (StNameTb.Text == "")
            {
                Key = 0;
            }

            else
            {

            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Student");
            }

            else
            {
                try
                {
                    Con.Open();

                    SqlCommand cmd = new SqlCommand("delete from studentTbl where StId= @StKey", Con);
                    cmd.Parameters.AddWithValue("@StKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Deleted");
                    Con.Close();
                    DisplayStudent();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }

        }

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

        private void foreverButton8_Click(object sender, EventArgs e)
        {
            Class Obj = new Class();
            Obj.Show();
            this.Hide();
        }
    }
}

