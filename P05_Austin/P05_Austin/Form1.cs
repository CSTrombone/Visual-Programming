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

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            totalPaidTxtBox.Text = "";
            monthsRepayTxtBox.Text = "";

            try
            {
                decimal borrowed = decimal.Parse(borrowedTxtBox.Text);
                decimal interest = decimal.Parse(interestTxtBox.Text);
                decimal payment = decimal.Parse(monthlyPaymentTxtBox.Text);
                
                CalulateSimulation(borrowed, interest, payment, out decimal totalPaid, out int monthsRepay);

                if (totalPaid != 0 && monthsRepay != 0)
                {
                    totalPaidTxtBox.Text = "$" + string.Format("{0:0.00}", totalPaid);
                    monthsRepayTxtBox.Text = string.Format("{0:0}", monthsRepay);
                }

            } 
            catch 
            {
                DialogResult invalidBox = MessageBox.Show("Invalid Data!");
                if (invalidBox == DialogResult.OK)
                {

                }
            }
        }

        public static void CalulateSimulation(decimal loan, decimal rate, decimal installment, out decimal totalPaid, out int monthsRepay)
        {
            totalPaid = monthsRepay = 0;

            if (loan < 0 || rate < 0 || installment < 0)
            {
                DialogResult negativeBox = MessageBox.Show("Negative numbers will not be accepted!");
                if (negativeBox == DialogResult.OK)
                {

                }
                return;
            }
            if ((loan * (rate / 100.0m / 12)) >= installment)
            {
                DialogResult interestBox = MessageBox.Show("Interest is too high, loan cannot be paid off!");
                if (interestBox == DialogResult.OK)
                {

                }
                return;
            }

            while (loan > 0)
            {
                if (installment > loan)
                {
                    totalPaid += loan;
                    monthsRepay += 1;
                    loan = 0;
                }
                else
                {
                    totalPaid += installment;
                    loan -= installment;
                    monthsRepay += 1;

                    loan += loan * (rate / 100.0m / 12);
                }
            }
        }
    }
}
