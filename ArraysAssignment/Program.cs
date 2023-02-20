using System;
using System.Collections.Generic;


namespace ArraysAssignment
{
    class Program
    {
        static void Main()
        {
            startofstring://start point of string array
            string[] stringArray = { "Red", "Green", "Blue", "Yellow", "Black" };// string array
            Console.WriteLine("Hi, Please select array from 0 to 4"); //outputs text to console

            int answer = Convert.ToInt32(Console.ReadLine()); // declares variable from user input
            if (answer > 4)//if user input is out of array then gives error message to user
            {
                Console.WriteLine("Something went wrong...Please press \"Enter\" to start again , Thanks");
                Console.ReadLine();
                goto startofstring;//go to start of string array

            }
            
            Console.WriteLine("You selected array number: " + answer + " and it stands for color: " + stringArray[answer]);// text output combined with variable "answer" and selects string position

            Console.WriteLine("");//empty line




            startofint: //start of int array

            int[] numArray2 = { 5, 2, 10, 5000, 600, 2300 }; //declares int array
            Console.WriteLine("Next Please select array from 0 to 5 to continue: ");//text output to console

            int number = Convert.ToInt32(Console.ReadLine());// declares variable from user input
            if (number > 5)//if user input is out of array then gives error text message to console
            {
                Console.WriteLine("Something went wrong ...Please press \"Enter\" to start again , Thanks");
                Console.ReadLine();
                goto startofint;// go to start of int array
            }
            Console.WriteLine("You selected array number: " + number + " and its equal to :" + numArray2[number]);// text output of variable and array position
            
            Console.WriteLine("");

            listofstrings:// go to start of int array

            List<string> intList = new List<string>(); //declares string list
            intList.Add("Dog"); //string list elements
            intList.Add("Cat");
            intList.Add("Parrot");
            intList.Add("Tiger");
            intList.Add("Lion");
            intList.Add("Snake");

            Console.WriteLine("Now i will try to guess Your favourite animal, \n \t please choose the number between 0 and 5"); //text output to console with instructions to user

            int stringlist = Convert.ToInt32(Console.ReadLine()); //declares variable from user input
            if (stringlist > 5)// if user input is out of list then gives text error message to user
            {
                Console.WriteLine("Something went wrong ...Please press \"Enter\" to start again , Thanks");
                Console.ReadLine();
                goto listofstrings;//go to start of string list 
            }
            Console.WriteLine("Hmm I would say that your favourite animal is: " + intList[stringlist]);// text output + list position
            Console.ReadLine();










        }
    }
}
