using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW7
{
    internal class BaseClass
    {

        public int Number {  get; set; }
        public virtual int this[ int index]
        {
            get 
            {
                string strNumber = Number.ToString();
                return int.Parse(strNumber[index].ToString());
            }
        }
       
    }
}
