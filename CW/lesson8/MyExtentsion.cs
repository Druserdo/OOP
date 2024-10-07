using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lesson9
{
    internal static class MyExtentsion
    {
        public static bool IsValiedEmail(this string s)
        {
            Regex regex = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
            return regex.IsMatch(s);
        }
        public static int CountChar(this string s, char ch)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (ch == s[i]) count++;
            }
            return count;
        }
    }
}
