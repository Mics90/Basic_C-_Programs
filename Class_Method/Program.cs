using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            math.Addition();
            Console.WriteLine("Type number for \"a\" value");
            math.Addition(Convert.ToInt32(Console.ReadLine()), 14);


            int z = math.Division(569, 13);
            double m = math.Division(19.62, 3.2);
            Console.WriteLine("Integer division : " + z);
            Console.WriteLine("Double division : " + m);
            Console.ReadLine();
        }
    }
}
