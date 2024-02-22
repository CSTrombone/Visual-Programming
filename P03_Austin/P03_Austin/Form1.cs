using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03_Austin
{
    public partial class program3 : Form
    {
        public program3()
        {
            InitializeComponent();
        }

        decimal total = 0.00m;

        private void orderBtn_Click(object sender, EventArgs e)
        {
            //Size Selection
            if(smallBtn.Checked == true)
            {
                total = 7.25m;
            }
            else if (mediumBtn.Checked == true)
            {
                total = 13.75m;
            }
            else if (largeBtn.Checked == true)
            {
                total = 16.50m;
            }
            //Crust Selection
            if (thickBtn.Checked == true)
            {
                total += 1.00m;
            }
            else if (panBtn.Checked == true)
            {
                total += 1.50m;
            }
            //Toppings
            for(int i = 0; i < 8; i++)
            {
                if (toppingsLstBox.GetItemChecked(i) == true)
                    total += 0.50m;
            }
            //Sides
            if (cheesebreadChkBox.Checked == true)
            {
                total += 1.00m;
            }
            if (saladChkBox.Checked == true)
            {
                total += 1.00m;
            }
            if (cheesesticksChkBox.Checked == true)
            {
                total += 1.00m;
            }
            //Drinks
            int addDrink = 0;
            int.TryParse(drinkTxtBox.Text, out addDrink);
            total += addDrink * 1.00m;

            //Message Box
            DialogResult confirmationBox = MessageBox.Show("Is this what you want?", "Your total is $" + total.ToString(), MessageBoxButtons.YesNo);
            if (confirmationBox == DialogResult.Yes)
            {
                smallBtn.Checked = true;
                thinBtn.Checked = true;
                cheesebreadChkBox.Checked = false;
                saladChkBox.Checked = false;
                cheesesticksChkBox.Checked = false;
                drinkTxtBox.Text = string.Empty;
                clearToppings(toppingsLstBox);
                toppingsLstBox.SelectedIndex = -1;
            }

        }        
        
        private void aboutBtn_Click(object sender, EventArgs e)
        {
            DialogResult aboutBox = MessageBox.Show("All ingredients are fresh when the pizza is delivered.\n\nIf you have any questions about the amount of fat, salt, or calories in the pizza then you probably should not order one.", "About Us", MessageBoxButtons.OK);
        }

        static void clearToppings(CheckedListBox selection)
        {
            for (int i = 0; i < 8; i++)
            {
                selection.SetItemChecked(i, false);
            }
        }


    }
}
