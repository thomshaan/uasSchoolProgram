using Avalonia.Controls;
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
    public partial class Events : Form
    {

        int Key = 0;

        public Events()
        {
            InitializeComponent();
            DisplayEvents();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\THOMAS\Documents\school.mdf;Integrated Security=True;Connect Timeout=30");

        private void DisplayEvents()
        {
            Con.Open();
            string Query = "Select * from EventsTbl";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            EDurationTb.Text = "";
            EDescTb.Text = "";

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventsTbl(EDesc, EDate, EDuration) values (@EvDesc, @EvDate, @EvDur)", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EDurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added");
                    Con.Close();
                    DisplayEvents();
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu();
            Obj.Show();
            this.Hide();
        }

        private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < EventsDGV.Rows.Count)
            {
                DataGridViewRow row = EventsDGV.Rows[e.RowIndex];

                EDescTb.Text = row.Cells[1].Value.ToString();
                EDate.Text = row.Cells[2].Value.ToString();
                EDurationTb.Text = row.Cells[3].Value.ToString();


                Key = Convert.ToInt32(row.Cells[0].Value);
            }

            if (EDescTb.Text == "")
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

                    SqlCommand cmd = new SqlCommand("delete from EventsTbl where EId= @EKey", Con);
                    cmd.Parameters.AddWithValue("@EKey", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Deleted");
                    Con.Close();
                    DisplayEvents();
                    Reset();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }




            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == ""||EDurationTb.Text =="")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventsTbl set EDesc=@EvDesc, EDate=@EvDate, EDuration=@EvDuration where EId=@EvID", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDuration", EDurationTb.Text);
                    cmd.Parameters.AddWithValue("@EvID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated");
                    Con.Close();
                    DisplayEvents();
                    Reset();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }


            }
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

        private void Fees_Click(object sender, EventArgs e)
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

        private void EDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void foreverButton8_Click(object sender, EventArgs e)
        {
            Class Obj = new Class();
            Obj.Show();
            this.Hide();
        }
    }
}
