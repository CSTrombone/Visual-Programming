namespace P11_Austin
{
    public delegate double DoOperation(double x, double y);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            DoOperation add = Add;
            double x,y;
            double.TryParse(amountTxtBox1.Text.Trim(),out x);
            double.TryParse(amountTxtBox2.Text.Trim(), out y);

            resultLbl.Text = add(x, y).ToString();
        }

        private void multpilyBtn_Click(object sender, EventArgs e)
        {
            DoOperation mult = Multiply;
            double x, y;
            double.TryParse(amountTxtBox1.Text.Trim(), out x);
            double.TryParse(amountTxtBox2.Text.Trim(), out y);

            resultLbl.Text = mult(x, y).ToString();
        }

        private double Multiply(double x, double y)
        {
            return x * y;
        }

        private double Add(double x, double y)
        {
            return x + y;
        }
    }
}
