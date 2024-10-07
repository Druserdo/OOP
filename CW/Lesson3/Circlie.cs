using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    internal class Circlie:Figur
    {
        private double radius;
        public double Radius 
        { 
            get => radius; 
            set
            {
                if (value < 0) radius = value;
            } 
        }

        public override double getArea()
        {
            return Math.PI * radius * radius;
        }

        public override double getPerimetr()
        {
            return 2 * Math.PI * radius;
        }
    }
}
