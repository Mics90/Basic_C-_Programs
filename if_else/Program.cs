using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else
{
    class Program
    {
        static void Main()
            
        {
            
            Console.WriteLine("Please enter number");
                int number = Convert.ToInt32(Console.ReadLine());
            if (number > 10)
            {
                Console.Write("Number is larger than 10");
            }
            else
            {
                Console.Write("Number is smaller than 10");

            }
            Console.Read();
            
        }
    }
}
