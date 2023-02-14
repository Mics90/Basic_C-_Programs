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
            if (weight > 50) // If the weight is greater than 50, display the error message
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.Read();
                return;
            }
            

            Console.WriteLine("What is the width of package?");// width of package
            int width = Convert.ToInt32(Console.ReadLine()); //converting to int
            Console.WriteLine("What is the height of package?"); //height of package
            int height = Convert.ToInt32(Console.ReadLine());// converting to int
            Console.WriteLine("What is the lenght of package?");//lenght of package
            int lenght = Convert.ToInt32(Console.ReadLine());//cconverting to int
             if ((width + height + lenght) > 50)//If the total of all dimensions is greater than 50, display the error message.
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.Read();
                return;

            }
            Console.WriteLine("");
            decimal quota = Convert.ToDecimal(((width * height * lenght) * weight) / 100);//multiplies the three dimensions together and multiply the product by the weight. Finally, divide the outcome by 100.

            Console.WriteLine("Your estimated total for shipping this package is: " + quota + "£  Thank You!");// displays price quota
            Console.ReadLine();
        }
        
    }
}
