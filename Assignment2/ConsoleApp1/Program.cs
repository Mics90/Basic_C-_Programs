using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine(" ");
            Console.WriteLine("What course are you in?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pagenr = Console.ReadLine();
            byte page = Convert.ToByte(pagenr);
            Console.WriteLine("Do you need help with anything? Answer \"true or \"false.");
            string anyhelp = Console.ReadLine();
            bool help = Convert.ToBoolean(anyhelp);
            Console.WriteLine("Were there any positive experiences you would like to share? Please provide specifics");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you would like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursstudy = Console.ReadLine();
            byte hours = Convert.ToByte(hoursstudy);
            Console.WriteLine("Thank you for your responses.  An instructor will respond shortly.  Have a great day.");
            Console.Read();
        }
    }
}
