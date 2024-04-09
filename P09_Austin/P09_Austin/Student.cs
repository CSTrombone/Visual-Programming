using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P09_Austin
{
    
    public class Student
    {
        private string _name = "";
        private double _earnedM = 0;
        private double _earnedF = 0;
        private double _possibleM = 0;
        private double _possibleF = 0;

        public Student()
        {
            
        }

        public Student(string name)
        {
            Name = name;
        }
        public Student(string name, double eM, double eF, double pM, double pF)
        {
            Name = name;
            EarnedM = eM;
            EarnedF = eF;
            PossibleM = pM;    
            PossibleF = pF;
        }

        public string Name { get; set; } = "Place_Holder";
        public double EarnedM { get; set; }
        public double EarnedF { get; set; }
        public double PossibleM { get; set; }
        public double PossibleF { get; set; }

        public virtual double Percentage ()
        {
            return (EarnedM + EarnedF) / (PossibleM + PossibleF) * 100;
        }
    }
}
