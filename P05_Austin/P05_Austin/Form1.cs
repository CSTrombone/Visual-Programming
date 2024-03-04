namespace P05_Austin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            borrowedTxtBox.Text = string.Empty;
            interestTxtBox.Text = string.Empty;
            monthlyPaymentTxtBox.Text = string.Empty;
            totalPaidTxtBox.Text = string.Empty;
            monthsRepayTxtBox.Text = string.Empty;
        }
        public int calc = 0;
        private void calculateBtn_Click(object sender, EventArgs e)
        {
            CalulateSimulation(ref calc);
            totalPaidTxtBox.Text = (calc).ToString();
            monthsRepayTxtBox.Text = (calc).ToString();
        }

        public static void CalulateSimulation(ref int pass)
        {
            pass += 1;
        }
    }
}
