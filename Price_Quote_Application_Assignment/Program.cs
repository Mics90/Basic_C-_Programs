using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Price_Quote_Application_Assignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("What is the package weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");

            }
            Console.WriteLine("What is the width of package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height of package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the lenght of package?");
            int lenght = Convert.ToInt32(Console.ReadLine());
             if ((width + height + lenght) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");

                
            }
            Console.WriteLine("");
            decimal quota = Convert.ToDecimal(((width * height * lenght) * weight) / 100);

            Console.WriteLine("Quota :" + quota + "£");
            Console.ReadLine();
        }
        
    }
}
