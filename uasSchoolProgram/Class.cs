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
    public partial class Class : Form
    {
        public Class()
        {
            InitializeComponent();
            DisplayClass();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private void ClassDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < ClassDGV.Rows.Count)
            {
                DataGridViewRow row = ClassDGV.Rows[e.RowIndex];

                ClassNameTb.Text = row.Cells[1].Value.ToString();
                ClassUserCb.Text = row.Cells[2].Value.ToString();
                ClassUseTimeCb.Text = row.Cells[3].Value.ToString();
                ClassDate.Text = row.Cells[4].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value);
            }

            if (ClassNameTb.Text == "")
            {
                Key = 0;
            }

            else
            {

            }
        }

        int Key = 0;

        private void DisplayClass()
        {
            Con.Open();
            string Query = "Select * from ClassTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ClassDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void FillClassUser()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StClass from StudentTbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StClass", typeof(int));
            dt.Load(rdr);
            ClassUserCb.ValueMember = "StClass";
            ClassUserCb.DataSource = dt;

            Con.Close();
        }

        private void Reset()
        {
            ClassNameTb.Text = "";
            ClassUserCb.Text = "";
            ClassDate.Text = "";
            ClassUseTimeCb.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (ClassNameTb.Text == "" || ClassUserCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into ClassTbl(ClassName, ClassCapacity, ClassUseTime, ClassDate) values (@CName, @CCapacity, @CUseTime, @CDate)", Con);
                    cmd.Parameters.AddWithValue("@CName", ClassNameTb.Text);
                    cmd.Parameters.AddWithValue("@CCapacity", ClassUserCb.Text);
                    cmd.Parameters.AddWithValue("@CUseTime", ClassUseTimeCb.Text);
                    cmd.Parameters.AddWithValue("@CDate", ClassDate.Value.Date);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Added");
                    Con.Close();
                    DisplayClass();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == 0)
            {
                MessageBox.Show("Select Class");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from ClassTbl where ClassId= @CID", Con);
                    cmd.Parameters.AddWithValue("@CID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Deleted");
                    Con.Close();
                    DisplayClass();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (ClassNameTb.Text == "" || ClassUserCb.Text == "" || ClassUseTimeCb.Text == "" || ClassDate.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update ClassTbl set ClassName=@CName,ClassCapacity=@CCapacity,ClassUseTime=@CUseTime,ClassDate=@CDate where ClassId=@CID", Con);
                    cmd.Parameters.AddWithValue("@CName", ClassNameTb.Text);
                    cmd.Parameters.AddWithValue("@CCapacity", ClassUserCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CUseTime", ClassUseTimeCb.Text);
                    cmd.Parameters.AddWithValue("@CDate", ClassDate.Value.Date);
                    cmd.Parameters.AddWithValue("@CID", Key);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Class Updated");
                    Con.Close();
                    DisplayClass();
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

        private void foreverButton1_Click(object sender, EventArgs e)
        {
            Student Obj = new Student();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {
            Teachers Obj = new Teachers();
            Obj.Show();
            this.Hide();
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

        private void foreverButton8_Click(object sender, EventArgs e)
        {
            Class Obj = new Class();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton7_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }
    }
}
