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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeacherTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeachersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            TnameTb.Text = "";
            SubCb.SelectedIndex = 0;
            TGenCB.SelectedIndex = 0;
            TPhoneTb.Text = "";
            TAddTb.Text = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int Key = 0;



        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCB.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeacherTbl(Tname,TGen,TPhone,TSub,TAdd,TDOB) values (@Tname,@Tgen,@TPhone,@TSub,@TAdd,@TDOB)", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.ExecuteNonQuery();
                    Con.Close();
                    DisplayTeachers();
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (TnameTb.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCB.SelectedIndex == -1 || SubCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TeacherTbl set Tname=@Tname,TGen=@TGen,TPhone=@TPhone,TSub=@TSub,TAdd=@TAdd,TDOB=@TDOB where TId=@TeachID", Con);
                    cmd.Parameters.AddWithValue("@Tname", TnameTb.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", SubCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeachers();
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
                MessageBox.Show("Select Teacher");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("delete from teacherTbl where TId= @TKey", Con);
                    cmd.Parameters.AddWithValue("@TKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Deleted");
                    Con.Close();
                    DisplayTeachers();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void TeachersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < TeachersDGV.Rows.Count)
            {
                DataGridViewRow row = TeachersDGV.Rows[e.RowIndex];

                TnameTb.Text = row.Cells[1].Value.ToString();
                TGenCB.SelectedItem = row.Cells[2].Value.ToString();
                TPhoneTb.Text = row.Cells[3].Value.ToString();
                SubCb.SelectedItem = row.Cells[4].Value.ToString();
                TAddTb.Text = row.Cells[5].Value.ToString();
                TDOB.Text = row.Cells[6].Value.ToString();

                Key = Convert.ToInt32(row.Cells[0].Value);
            }

            if (TnameTb.Text == "")
            {
                Key = 0;
            }

            else
            {

            }
        }



        //UI

        private void foreverButton1_Click_1(object sender, EventArgs e)
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

        private void foreverButton5_Click_1(object sender, EventArgs e)
        {
            Dashboard Obj = new Dashboard();
            Obj.Show();
            this.Hide();
        }

        private void foreverButton6_Click_1(object sender, EventArgs e)
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
