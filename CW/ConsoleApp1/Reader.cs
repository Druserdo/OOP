using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Reader:Person
    {
        private ulong number;
        public ulong Number
        { 
            get { return number; } 
            set { if(value>0) number = value; }
           
        }
        public string? Faculty {  get; set; }

        public override void TakeBook(params Book[] books)
        {
            base.TakeBook(books);
        }

        public override void TkeBook(int n)
        {
            base.TkeBook(n);
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
