using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P09_Austin
{
    public class Graduate : Student
    {
        private double _earnedP = 0;
        private double _possibleP = 0;

        public Graduate() : base()
        {

        }

        public Graduate(string name) : base(name)
        {

        }

        public Graduate(string name, double eM, double eF, double eP, double pM, double pF, double pP) : 
            base(name, eM, eF, pM, pF)
        {
            EarnedP = eP;
            PossibleP = pP;
        }

        public double EarnedP { get; set; }
        public double PossibleP { get; set; }

        public override double Percentage()
        {
            return (EarnedM + EarnedF + EarnedP) / (PossibleM + PossibleF + PossibleP) * 100;
        }
    }
}
