using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12._2
{
    internal class Student<T> : ICloneable, IComparable<T>
    {
        public string FIO { get; set; }
        public T Group { get; set; }
        private int[] marks = new int[5];
        public Student(string _s, T _g)
        {
            FIO = _s;
            Group = _g;
            Random random = new Random();
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = random.Next(2, 6);
            }
        }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student<T>)
            {
                var student = obj as Student<T>;
                if (this.Group is int)
                {
                    if ((int)Group > student.Group) return 1;
                    else if (Group == student.Group) return 0;
                    return 0;
                }
            }
        }

    }
}
