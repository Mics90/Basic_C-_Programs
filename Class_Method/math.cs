using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class math
    {
        public static void Addition(int a = 3, int b = 5)
        {
            int c = (a + b) / 2;
            Console.WriteLine("a+b/2 b=14 \nResult:" + c);
        }
        public static int Division(int x, int y)
        {
            return x / y;

        }
        public static double Division(double x, double y)
        {
            return x / y;
        }
    }
}
