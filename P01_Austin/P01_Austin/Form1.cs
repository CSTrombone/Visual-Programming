namespace P01_Austin
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void btnTalk_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Greetings from Austin Oden!";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }
}
