using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Delegat
{
    delegate void MyDelegate();
    internal class MyClass
    {
       public static void Main()
        {
            MyDelegate mes;
            mes = Hello;
            mes();
            void Hello()=> Console.WriteLine("Hello, me");
        }
    }
}
