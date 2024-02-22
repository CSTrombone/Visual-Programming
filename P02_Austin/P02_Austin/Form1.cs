using System;
using System.Windows.Forms;

namespace P02_Austin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        const decimal TAX_RATE = 0.05m;

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult endBox = MessageBox.Show("Program ended");
            if (endBox == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearBoard();
            listpriceTxtBox.Focus();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal listpriceVar = decimal.Parse(listpriceTxtBox.Text);
                decimal discountVar = decimal.Parse(discountTxtBox.Text);
                decimal totaldiscountVar = listpriceVar * (discountVar /100m);

                if (listpriceVar < 0 || discountVar < 0)
                {
                    DialogResult negativeBox = MessageBox.Show("Negative numbers are not accepted!");
                    if (negativeBox == DialogResult.OK)
                    {
                        clearBoard();
                        listpriceTxtBox.Focus();
                        listpriceVar = 0;
                        discountVar = 0;
                        totaldiscountVar = 0;
                    }
                }
                else
                {
                    tlpOutLabel.Text = string.Format("{0:0.00}", listpriceVar);
                    tdaOutLabel.Text = string.Format("{0:0.00}", totaldiscountVar);
       
                    ttOutLabel.Text = string.Format("{0:0.00}", ((listpriceVar - totaldiscountVar) * TAX_RATE));
                    tnpOutLabel.Text = string.Format("{0:0.00}", ((listpriceVar - totaldiscountVar) * TAX_RATE) + (listpriceVar - totaldiscountVar));
                }
            }
            catch
            {
                DialogResult negativeBox = MessageBox.Show("Invalid Data!");
                if (negativeBox == DialogResult.OK)
                {
                    clearBoard();
                    listpriceTxtBox.Focus();
                }
            }
        }

        public void clearBoard()
        {
            listpriceTxtBox.Clear();
            discountTxtBox.Clear();
            tlpOutLabel.Text = "0.00";
            tdaOutLabel.Text = "0.00";
            ttOutLabel.Text = "0.00";
            tnpOutLabel.Text = "0.00";
        }
    }
}
