using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_methods_assignment_1
{
    class Math
    {
        public int Integer(int a, int b)
        {
            return a + b;
        }
        public decimal Decimal(decimal a, decimal b)
        {
            return Convert.ToDecimal(a / b);
        }
        public int String(string a, string b)
        {
            return Convert.ToInt32(a) - Convert.ToInt32(b);
        }
    }
}
