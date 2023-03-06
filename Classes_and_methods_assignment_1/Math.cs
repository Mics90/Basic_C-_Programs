using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_methods_assignment_1
{
    class Math
    {
        public static int Integer(int a, int b)
        {
            return a + b;
        }
        public static decimal Decimal(decimal a, decimal b)
        {
            return Convert.ToDecimal(a / b);
        }
        public static int String(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }
    }
}
