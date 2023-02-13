using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationAssignmentSubmiussion
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Please write any number"); //user input
            
            int number = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            int answer = number * 50; //multiplies user input by 50
            Console.WriteLine("Your number multiplied by 50 equals to " + answer); // outputs result
            

            Console.WriteLine("Please write another number"); //user input

            int number2 = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            int answer2 = number2 + 25; //ads 25 to usere input
            Console.WriteLine("We added 25 to your number and result is:  " + answer2); // outputs result

            Console.WriteLine("Please write another number"); //user input
            double number3 = Convert.ToDouble(Console.ReadLine()); //converts user input to double
            double answer3 = number3 / 12.5; //dividing user input by 12.5
            Console.WriteLine("We devided Your number by 12.5 and result is:  " + answer3); // outputs result
            

            Console.WriteLine("Please write another number"); //user input
            int number4 = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            bool answer4 = number4 > 50; //checks if user input is greater than 50
            Console.WriteLine("Your number greater than 50 =  " + answer4); // outputs result
            

            Console.WriteLine("Please write another number"); //user input

            int number5 = Convert.ToInt32(Console.ReadLine()); //converts user input to int
            int answer5 = number5 % 7; //divides usere input bby 7 and gives reminder
            Console.WriteLine("When deviding your nuber by 7 , the remainder is:  " + answer5); // outputs result
            

            Console.WriteLine("Thanks, Please press 'Enter' to exit!");
            Console.Read();








        }
    }
}
