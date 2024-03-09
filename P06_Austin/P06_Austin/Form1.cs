using System.Diagnostics;
using static System.Windows.Forms.LinkLabel;

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
            if (menuListBox.SelectedIndex != -1)
                priceTxtBox.Text = "$" + prices[menuListBox.SelectedIndex].ToString();
        }



        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                addToList();
                menuListBox.SelectedIndex = -1;
                priceTxtBox.Text = "$0.00";
            }
            catch
            {
                DialogResult invalidInput = MessageBox.Show("At least one input is invalid!", "Error", MessageBoxButtons.OK);
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            orderListBox.Items.Remove(orderListBox.SelectedItem);
            orderListBox.SelectedIndex = -1;

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderListBox.Items.Count != 0 ||  
                nameTxtBox.Text != string.Empty ||
                phoneTxtBox.Text != string.Empty ||
                boxesTxtBox.Text != string.Empty    )
            {
                DialogResult saveQuery = MessageBox.Show("Would you like to save this file?", "Exit without saving?", MessageBoxButtons.YesNoCancel);
                if (saveQuery == DialogResult.Yes)
                {
                    //save procedure
                }
                else if (saveQuery == DialogResult.No)
                {
                    Close();
                }
                else if (saveQuery == DialogResult.Cancel)
                {

                }
            }
            else
            {
                Close();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult saveQuery = MessageBox.Show("Would you like to save this file?", "Overwrite existing window?", MessageBoxButtons.YesNoCancel);
            if (saveQuery == DialogResult.Yes)
            {
                //save procedure
            }
            else if (saveQuery == DialogResult.No)
            {
                Clear();
            }
            else if (saveQuery == DialogResult.Cancel)
            {

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //save procedure
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult about = MessageBox.Show("This is us", "About Us", MessageBoxButtons.OK);
        }

        public void addToList()
        {
            decimal total = 0; 
            Decimal.TryParse(boxesTxtBox.Text, out total);
            total = total * prices[menuListBox.SelectedIndex];
            orderListBox.Items.Add(nameTxtBox.Text + phoneTxtBox.Text + boxesTxtBox.Text + "$" + total + menuListBox.SelectedItem);
        }
        public void Clear()
        {
            orderListBox.Items.Clear();
            nameTxtBox.Text = string.Empty;
            phoneTxtBox.Text = string.Empty;
            boxesTxtBox.Text = string.Empty;
            priceTxtBox.Text = "$0.00";
            menuListBox.SelectedIndex = -1;
        }
    }
}