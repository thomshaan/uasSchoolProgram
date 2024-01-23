namespace uasSchoolProgram
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        int startPoint = 0;


        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            startPoint += 1;
            myProgressBar.Value = startPoint;

            if(myProgressBar.Value == 100) { 
            
            myProgressBar.Value = 0;
            timer1.Stop();
                LoginForm Obj = new LoginForm();
                this.Hide();
                Obj.Show();

            }


        }
    }
}