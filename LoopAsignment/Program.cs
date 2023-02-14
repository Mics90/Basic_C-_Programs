using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Assignment
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.Green;// sets text color green
           

            Console.WriteLine("What is My favourite day of the week?");
            string weekday = Console.ReadLine();
            bool ismyday = weekday == "Friday"; //sets bool answer that equal to true
            do  //starts loop
            {
                switch (weekday)//switch statement
                {
                    case "Monday"://case statement
                        Console.WriteLine("Monday is a cool day but its not my favourite day!");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;//stops loop
                    case "Tuesday":
                        Console.WriteLine("Tuesday is nice day, but its not my favourite.");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;
                    case "Wednesday":
                        Console.WriteLine("Wednesday is middle of week but its not my favourite..");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;
                    case "Thursday":
                        Console.WriteLine("You almost guessed right..");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;

                    case "Friday":
                        Console.WriteLine("You guessed right,Friday is my Favourite day!");
                       
                        ismyday = true;//sets bool variable to true
                        break;
                    case "Saturday":
                        Console.WriteLine("Saturday is my second favourite day!");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;
                   case "Sunday":
                        Console.WriteLine("Sunday is a nice day!! but its not my favourite");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please start with capital leter.");
                        Console.WriteLine("What is My favourite day of the week?");
                        weekday = Console.ReadLine();
                        break;
                }
            }
            while (!ismyday);// makes to do loop while boolean is false



            Console.ReadLine();

        }
    }
}
