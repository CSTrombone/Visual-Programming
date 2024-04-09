using System.CodeDom.Compiler;
using System.Security.Permissions;
using System.Threading;
using System.Xml.Linq;

namespace P09_Austin
{
    public partial class Grades : Form
    {
        private StudentInfo studentInfo;
        private GraduateInfo gradInfo;

        public static List<Student> students = new List<Student>();

        public Grades()
        {
            InitializeComponent();
        }

        private void underBtn_Click(object sender, EventArgs e)
        {
            
            studentInfo = new StudentInfo();
            studentInfo.ShowDialog();
        }

        private void gradBtn_Click(object sender, EventArgs e)
        {
            gradInfo = new GraduateInfo();
            gradInfo.ShowDialog();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            infoLstBox.Items.Clear();

            foreach (Student s in students)
            {
                string data = "Error";
                if (s is Graduate)
                {
                    Graduate g = (Graduate)s;
                    data = String.Format("{0,-17}{1, -9}{2, -9}{3, -10}{4, -5}", g.Name, g.EarnedM + "/" + g.PossibleM, g.EarnedF + "/" + g.PossibleF, g.EarnedP + "/" + g.PossibleP, s.Percentage().ToString("F1") + "%");
                }
                else
                {
                    data = String.Format("{0,-17}{1, -9}{2, -19}{3, -5}", s.Name, s.EarnedM + "/" + s.PossibleM, s.EarnedF + "/" + s.PossibleF, s.Percentage().ToString("F1") + "%");
                }

                infoLstBox.Items.Add(data);
            }
            
        }
    }
}
