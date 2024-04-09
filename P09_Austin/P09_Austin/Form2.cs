using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P09_Austin
{
    public partial class StudentInfo : Form
    {
        public StudentInfo()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Grades.students.Add(new Student
                (
                nameTxtBox.Text.Trim(), 
                Convert.ToDouble(eMTxtBox.Text.Trim()), 
                Convert.ToDouble(eFTxtBox.Text.Trim()), 
                Convert.ToDouble(pMTxtBox.Text.Trim()), 
                Convert.ToDouble(pFTxtBox.Text.Trim()))
                ); 
            
            Close();
        }
        
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
