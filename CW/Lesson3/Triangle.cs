using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Triangle:Figur
    {
        private double a;
        public double A 
        { 
            get=>a;
            set { if (value > 0) a = value; }
        }
        private double b;
        public double B
        {
            get => b;
            set { if (value > 0) b = value; }
        }
        private double c;
        public double AC
        {
            get => c;
            set { if (value > 0) c = value; }
        }

        public override double getArea()
        {
            double pp = getPerimetr()/2;
            return Math.Sqrt(pp * (pp - a) * (pp - b) * (pp - c));
        }

        public override double getPerimetr()
        {
            return a + b + c;
        }
    }
}
