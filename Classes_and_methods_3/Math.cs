using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_methods_3
{
    class Math
    {
        public static void method(int a = 12, int b = 16)
        {

            int c = a / 4;
            Console.WriteLine("Result of a / 4,where \"a\" is " + a + " : " + c + "\nsecond integer is: " + b);

        }
    }
}
