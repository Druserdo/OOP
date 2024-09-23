using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson7
{
    internal class Trayn
    {
        private int number;
        public int Number 
        {  
            get { return number; }
            set { number = value; }
        }
        public string? Destination {  get; set; }
        public TimeOnly? TimeArived { get; set; }
        public TimeOnly? TimeDeparture { get; set; }
    }
}
