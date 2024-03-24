using System.CodeDom.Compiler;
using System.ComponentModel;

namespace P07_Austin
{
    public partial class Grades : Form
    {

        struct StudentInfo(string name)
        {
            private const int ROWS = 2;
            private const int COLS = 3;

            public string _name = name;
            public double[,] _points = new double[ROWS, COLS];

        }

        Dictionary<string, StudentInfo> StudentDictonary = new Dictionary<string, StudentInfo>()
        {
           
        };

        public Grades()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            { 
                StudentDictonary.Add(nameTxtBox.Text, new StudentInfo(nameTxtBox.Text));

                StudentInfo temp = StudentDictonary[nameTxtBox.Text];

                temp._points[0, 0] = double.Parse(earned1TxtBox.Text);
                temp._points[0, 1] = double.Parse(earned2TxtBox.Text);
                temp._points[0, 2] = double.Parse(earned3TxtBox.Text);
                temp._points[1, 0] = double.Parse(possible1TxtBox.Text);
                temp._points[1, 1] = double.Parse(possible2TxtBox.Text);
                temp._points[1, 2] = double.Parse(possible3TxtBox.Text);
            }
            catch 
            {
                StudentDictonary.Remove(nameTxtBox.Text);
                DialogResult = MessageBox.Show("Error");
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try 
            {
                if (StudentDictonary.ContainsKey(nameTxtBox.Text))
                {
                    earned1TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[0, 0].ToString("#.##");
                    earned2TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[0, 1].ToString("#.##");
                    earned3TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[0, 2].ToString("#.##");
                    possible1TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[1, 0].ToString("#.##");
                    possible2TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[1, 1].ToString("#.##");
                    possible3TxtBox.Text = StudentDictonary[nameTxtBox.Text]._points[1, 2].ToString("#.##");
                }
                else
                {
                    DialogResult = MessageBox.Show("Student not found!");
                }

            }
            catch
            {
                DialogResult = MessageBox.Show("Error");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentDictonary.ContainsKey(nameTxtBox.Text))
                {
                    StudentDictonary[nameTxtBox.Text]._points[0, 0] = double.Parse(earned1TxtBox.Text);
                    StudentDictonary[nameTxtBox.Text]._points[0, 1] = double.Parse(earned2TxtBox.Text);
                    StudentDictonary[nameTxtBox.Text]._points[0, 2] = double.Parse(earned3TxtBox.Text);
                    StudentDictonary[nameTxtBox.Text]._points[1, 0] = double.Parse(possible1TxtBox.Text);
                    StudentDictonary[nameTxtBox.Text]._points[1, 1] = double.Parse(possible2TxtBox.Text);
                    StudentDictonary[nameTxtBox.Text]._points[1, 2] = double.Parse(possible3TxtBox.Text);
                }
                else
                {
                    DialogResult = MessageBox.Show("Student not found!");
                }

            }
            catch
            {
                DialogResult = MessageBox.Show("Error");
            }
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                StudentDictonary.Remove(nameTxtBox.Text);
                Clear();
            }
            catch
            {
                DialogResult = MessageBox.Show("Student not found!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void Clear()
        {
            nameTxtBox.Text = "";
            earned1TxtBox.Text = "";
            earned2TxtBox.Text = "";
            earned3TxtBox.Text = "";
            possible1TxtBox.Text = "";
            possible2TxtBox.Text = "";
            possible3TxtBox.Text = "";
        }
    }
}
