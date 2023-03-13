using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a day of the week");
            string YourDay = Console.ReadLine();
            string ActualDay = DateTime.Now.DayOfWeek.ToString();
            try
            {
                if (YourDay == ActualDay)
                {
                    Console.WriteLine("Today is : " + YourDay);
                }
                {
                    if (YourDay != ActualDay)
                        throw new ArgumentNullException();
                }
            }
            catch (Exception)

            {
                Console.WriteLine("Please check your spelling!");
            }

            finally
            {
                Console.ReadLine();
            }
        }
    }
}
