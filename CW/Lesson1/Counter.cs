using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    internal class Counter
    {
        private int count;  //поле класса

        public Counter(int c)
        {
            Count = c;
        }
        public Counter()
        {
            Count = 0;
        }

        public int Count    //свойства класса
        {
            get { return count; }
            set { this.count = value; }
        }

    }
}
