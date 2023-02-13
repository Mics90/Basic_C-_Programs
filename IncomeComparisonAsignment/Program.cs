using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComparisonAsignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person1");
            Console.WriteLine("Hourly Rate?");
            double person1rate = Convert.ToDouble(Console.ReadLine());//converts user input to double
            
            Console.WriteLine("Hours worked per week?");
            double person1hours = Convert.ToDouble(Console.ReadLine()); //converts user input to double
            

            Console.WriteLine("Person2");
            Console.WriteLine("Hourly Rate?");
            double person2rate = Convert.ToDouble(Console.ReadLine());//converts user input to double

            Console.WriteLine("Hours worked per week?");
            double person2hours = Convert.ToDouble(Console.ReadLine());//converts user input to double

            double weektotal = person1rate * person1hours; //calculates person 1 weekly wages
            double annual = weektotal * 12; //calculates person 1 annual wages

            Console.Write("\n Annual sallary of person 1: \n" + annual);
            double weektotal2 = person2rate * person2hours; // calculates person 2 weekly wages

            double annual2 = weektotal2 * 12; // calculates person 2 annual wages
            Console.Write("\n Annual sallary of person 2 \n " + annual2);
            Console.WriteLine("");

            bool comparison = annual > annual2; // compares person 1 and persoin 2 wages
            Console.WriteLine(" \n Person 1 makes more money than Person2 :  \n" + comparison);
            Console.ReadLine();


        }
    }
}
