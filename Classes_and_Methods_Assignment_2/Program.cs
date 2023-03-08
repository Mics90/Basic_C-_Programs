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
                math mathOb = new math();
                Console.WriteLine("Please enter first number!");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter second number (optional)");

                string b = Console.ReadLine();
                if (b == "")
                {
                    int c = mathOb.addition(a);
                    Console.WriteLine("Result is : " + c);
                    Console.Read();
                }
                else
                {
                    int c = mathOb.addition(a,Convert.ToInt32(b));
                    Console.WriteLine("Result is : " + c);
                    Console.Read();
                }


                

            }

           
        }
    }
}
