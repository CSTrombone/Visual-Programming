using System.CodeDom.Compiler;
using System.ComponentModel;

namespace P08_Austin
{
    public partial class Grades : Form
    {
        public Grades()
        {
            InitializeComponent();
        }
        class StudentInfo(string name)
        {
            private const int ROWS = 2;
            private const int COLS = 3;

            public string _name = name;
            public double[,] _points = new double[ROWS, COLS];

        }

        Dictionary<string, StudentInfo> StudentDictonary = new Dictionary<string, StudentInfo>()
        {

        };

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (StudentDictonary.ContainsKey(nameTxtBox.Text.Trim()))
                {
                    throw new Exception();
                }

                StudentDictonary.Add(nameTxtBox.Text.Trim(), new StudentInfo(nameTxtBox.Text.Trim()));


                StudentInfo temp = StudentDictonary[nameTxtBox.Text.Trim()];

                temp._points[0, 0] = validateString(earned1TxtBox.Text.Trim());
                temp._points[0, 1] = validateString(earned2TxtBox.Text.Trim());
                temp._points[0, 2] = validateString(earned3TxtBox.Text.Trim());
                temp._points[1, 0] = validateString(possible1TxtBox.Text.Trim());
                temp._points[1, 1] = validateString(possible2TxtBox.Text.Trim());
                temp._points[1, 2] = validateString(possible3TxtBox.Text.Trim());
            }
            catch (Exception ex)
            {
                if (ex is InvalidOperationException)
                {
                    StudentDictonary.Remove(nameTxtBox.Text.Trim());
                    DialogResult = MessageBox.Show("Invalid Input!");
                }
                else
                    DialogResult = MessageBox.Show("Error");
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (StudentDictonary.ContainsKey(nameTxtBox.Text.Trim()))
                {
                    earned1TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 0]);
                    earned2TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 1]);
                    earned3TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 2]);
                    possible1TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 0]);
                    possible2TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 1]);
                    possible3TxtBox.Text = displayNumbers(StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 2]);
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
                if (StudentDictonary.ContainsKey(nameTxtBox.Text.Trim()))
                {
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 0] = validateString(earned1TxtBox.Text.Trim());
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 1] = validateString(earned2TxtBox.Text.Trim());
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[0, 2] = validateString(earned3TxtBox.Text.Trim());
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 0] = validateString(possible1TxtBox.Text.Trim());
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 1] = validateString(possible2TxtBox.Text.Trim());
                    StudentDictonary[nameTxtBox.Text.Trim()]._points[1, 2] = validateString(possible3TxtBox.Text.Trim());
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
                if (!StudentDictonary.ContainsKey(nameTxtBox.Text.Trim()))
                {
                    throw new Exception();
                }
                else
                {
                    StudentDictonary.Remove(nameTxtBox.Text.Trim());
                    Clear();
                }
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

        //Quality of life
        private void textUpdate(object sender, EventArgs e)
        {
            switch (StudentDictonary.ContainsKey(nameTxtBox.Text.Trim()))
            {
                case true:
                    checkmarkPicBox.Visible = true;
                    break;
                default:
                    checkmarkPicBox.Visible = false;
                    break;
            }


        }

        double validateString(string text)
        {
            if (double.Parse(text) == 0)
            {
                return 0;
            }
            else if (double.Parse(text) < 0)
            {
                throw new InvalidOperationException();
            }
            else if (double.Parse(text) != 0 && double.Parse(text) > 0)
            {
                return double.Parse(text);
            }
            else
            {
                return 0;
            }
        }

        string displayNumbers(double text)
        {
            if (text == 0)
            {
                return "0";
            }
            else
            {
                return text.ToString("#.##");
            }
        }
    }
}
