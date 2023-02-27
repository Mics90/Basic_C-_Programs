using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select a number to add");
            int a = Math.addition(2, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Addition result is : " + a);
            Console.WriteLine("Please select a number to substract");
            int b = Math.substraction(8, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Substraction result is : " + b);
            Console.WriteLine("Please select a number to multiply");
            int c = Math.multiplication(3, Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Multiplication result is : " + c);

            Console.ReadLine();
        }
    }
}
