using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine("Please type a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            DateTime answer = DateTime.Now.AddHours(number);
            Console.WriteLine("After " + number + " hours, time will be: " + answer );
            Console.ReadLine();
        }
    }
}
