using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is Your age?");
            int age = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            
            Console.WriteLine("Have you ever had a DUI violation? Please answer with True or False");
            bool violation = Convert.ToBoolean(Console.ReadLine());// converts user input to boolean
            Console.WriteLine("How many speeding tickets have you had?");
            int tickets = Convert.ToInt32(Console.ReadLine()); // converts user input to int
            Console.WriteLine("Qualified? : " + (violation == false && tickets < 3 && age > 15)) ; //checks if qualified with AND operators
            Console.ReadLine();
        }
    }
}
