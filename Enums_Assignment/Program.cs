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
            try
            {
                Console.WriteLine("What is my favourite day?");
                string Input = Console.ReadLine();
                string Day = Convert.ToString(DaysOfTheWeek.Days.Friday);

                

                    if (Input == Day)
                    {
                        Console.WriteLine("You entered : " + Input);
                    }
                    else
                {
                    Console.WriteLine("Sorry, but " + Input + " is not my favourite day!");

                }
                
            }


            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.ReadLine();
            }

        }
    }
}
