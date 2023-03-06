using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Methods_Assignment_2
{
    class Program
    {
        static void Main(string[] args)

        {
            
            {
                
                Console.WriteLine("Please enter first number!");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter second number (optional)");

                string b = Console.ReadLine();
                if (b.Equals(string.Empty))
                {
                    Console.WriteLine("Math result: " + a);
                    Console.ReadLine();
                }
                else
                {
                    int c = math.addition(a, Convert.ToInt32(b));
                    Console.WriteLine("Result is : " + c);
                    Console.Read();
                }

                

            }
           
        }
    }
}
