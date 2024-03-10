using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P06_Austin
{
    public partial class Form1 : Form
    {
        //Load Menu Text File
        readonly decimal[] prices = new decimal[30]; //Allows for up to 30 menu items depending on entries in text file.

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
                if (menuListBox.SelectedIndex != -1 && (nameTxtBox.Text == string.Empty || phoneTxtBox.Text == string.Empty || boxesTxtBox.Text == string.Empty))
                {
                    throw new Exception();
                }
                decimal total = 0;
                Decimal.TryParse(boxesTxtBox.Text, out total);
                total = total * prices[menuListBox.SelectedIndex];
                orderListBox.Items.Add(nameTxtBox.Text + phoneTxtBox.Text + boxesTxtBox.Text + "$" + total + menuListBox.SelectedItem);

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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderListBox.Items.Count != 0 ||
                nameTxtBox.Text != string.Empty ||
                phoneTxtBox.Text != string.Empty ||
                boxesTxtBox.Text != string.Empty) 
            {
                DialogResult saveQuery = MessageBox.Show("Would you like to save this file?", "Overwrite existing window?", MessageBoxButtons.YesNoCancel);
                if (saveQuery == DialogResult.Yes)
                {
                    saveProdecure();
                    Clear();
                }
                else if (saveQuery == DialogResult.No)
                {
                    Clear();
                }
                else if (saveQuery == DialogResult.Cancel)
                {

                }
            }
            else
            {
                Clear();
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader streamReader = new StreamReader(openDialog.FileName))
                {
                    string line = "\n";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        orderListBox.Items.Add(line);
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveProdecure();
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (orderListBox.Items.Count != 0 ||
                nameTxtBox.Text != string.Empty ||
                phoneTxtBox.Text != string.Empty ||
                boxesTxtBox.Text != string.Empty)
            {
                DialogResult saveQuery = MessageBox.Show("Would you like to save this file?", "Exit without saving?", MessageBoxButtons.YesNoCancel);
                if (saveQuery == DialogResult.Yes)
                {
                    saveProdecure();
                    Close();
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
       
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult about = MessageBox.Show("This is us", "About Us", MessageBoxButtons.OK);
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

        public void saveProdecure()
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.FileName = "Order Form";
                saveDialog.InitialDirectory = Environment.CurrentDirectory;
                saveDialog.Title = "Save Order Form";
                saveDialog.CheckPathExists = true;
                saveDialog.DefaultExt = "txt";
                saveDialog.Filter = "Text files (*.txt)|*.txt";
                saveDialog.FilterIndex = 1;
                saveDialog.RestoreDirectory = true;

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (Stream newFile = File.Open(saveDialog.FileName, FileMode.OpenOrCreate))
                    using (StreamWriter writeStream = new StreamWriter(newFile))
                    {
                        for (int i = 0; i < orderListBox.Items.Count; i++)
                        {
                            writeStream.WriteLine(orderListBox.Items[i].ToString());
                        }
                    }
                }
            }
            catch
            {
                DialogResult denied = MessageBox.Show("Access Denied");
            }

        }

    }
}