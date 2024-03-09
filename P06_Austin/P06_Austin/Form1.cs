using System.Diagnostics;

namespace P06_Austin
{
    public partial class Form1 : Form
    {
        decimal[] prices = new decimal[5];

        public Form1()
        {
            InitializeComponent();

            priceTxtBox.Text = "$0.00";

            using (StreamReader streamReader = new StreamReader("cookie_menu.txt"))
            {
                string line = "\n";
                decimal price = 0.0m;
                int menuIndex = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (Decimal.TryParse(line, out price))
                    {
                        prices[menuIndex] = price;
                        menuIndex++;
                    }
                    else
                    {
                        menuListBox.Items.Add(line);
                    }
                }
            }
        }

        private void menuListBox_SelectChanged(object sender, EventArgs e)
        {
            priceTxtBox.Text = "$" + prices[menuListBox.SelectedIndex].ToString();
        }
    }
}