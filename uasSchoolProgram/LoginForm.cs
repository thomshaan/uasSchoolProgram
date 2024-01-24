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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void foreverButton1_Click(object sender, EventArgs e)
        {
            if (UNameTb.Text == "" || PasswordTb.Text=="")
            {
                MessageBox.Show("Enter Username and Password");
            }
            else if (UNameTb.Text =="Admin" && PasswordTb.Text == "Password")
            {
                MainMenu Obj = new MainMenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password");
                UNameTb.Text = "";
                PasswordTb.Text = "";
            }
        }

        private void foreverButton2_Click(object sender, EventArgs e)
        {
            UNameTb.Text = "";
            PasswordTb.Text  = "";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
