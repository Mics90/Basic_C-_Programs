using System;
using System.Collections.Generic;


namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
            /////////////////////////////////         PART 1          ///////////////////////////////////////////////////////
        {
            string[] animals = {"Cat", "Dog", "Tiger", "Lion" }; // string of animals
            List<string> animalsupdated = new List<string>(); // updated string list of animals

            Console.WriteLine("Please enter any adjective: "); // console text output asking to input text

            string adjective = Console.ReadLine();// declares variable from user input

            foreach (string animal in animals)// foreach loop 
            {

                {
                    animalsupdated.Add(adjective + " " + animal); //ads adjective to animal in new string list of animals
                }
            }
            foreach (string animal in animalsupdated) //foreach loop to print out updated list of animals
            {

                Console.WriteLine(animal);

            }
            ///////////////////////////PART2//////////////////////////////////////////////////////////////////
            //for (int j = 0; j < animalsupdated.Count;)//infinite loop
            for (int j = 0; j < animalsupdated.Count; j++)// fixed infinite loop
            {

                {
                    Console.WriteLine(animalsupdated[j]);

                }
                


            }
            //////////////////////////PART 3///////////////////////////////////////////////////////////////////
            int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };//loop whre the comparison thats used to determine whether to continue iterating the loop is "<"

            for (int k = 0; k < testscores.Length; k++)
            {
                if (testscores[k] < 85)
                {
                    Console.WriteLine("Failing test score: " + testscores[k]);
                }
            }
            



            int[] testscores2 = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };//loop whre the comparison thats used to determine whether to continue iterating the loop is "<="

            for (int k = 0; k < testscores2.Length; k++)
            {
                if (testscores2[k] <= 85)
                {
                    Console.WriteLine("Failing test score: " + testscores2[k]);
                }
            }
            
            ///////////////////////////////////////PART 4/////////////////////////////////////////////////////////

            List<string> people = new List<string>() { "JESSE", "ERIK", "ADAM", "DANIEL", "MARTA", "JOHN" }; //string list
            Console.WriteLine("Hi. Please enter your name to check if you are in the guest list."); //text output to console
            string guestlist = Console.ReadLine(); //declares variable from user input
            string guestlist2 = guestlist.ToUpper(); // capitalize user input to avoid capital leter errors



            foreach (string guest in people)//loop to check strings in list
            {
                if (people.Contains(guestlist2)) //if statement if input maches list 
                {

                        Console.WriteLine("Your name is in the list. You are guest nr: " + people.IndexOf(guestlist2)); //console output with index of list matching input

                    break;
                }
                    if(!people.Contains(guestlist2))
                    { 
                        Console.WriteLine("Sorry! Your name is not in the list!");

                    break;
                        
                    }
                    
             }
            Console.ReadLine();

            ////////////////////////////////PART 5///////////////////////////////////////////
            string[] cars = { "BMW", "AUDI", "AUDI", "VOLVO", "MERCEDESS", "GOLF", "SUBARU", "ROVER" };
            Console.WriteLine("What is your favourite car model?");
            
            string favCar = Console.ReadLine();
            string favCar2 = favCar.ToUpper();
            for (int k = 0; k < cars.Length; k++)

            {
                if (cars[k] == favCar2)
                {
                    Console.WriteLine("We have found " + cars[k] + " in our records!");
                    break;
                }
                else
                {
                    Console.WriteLine("\"" + favCar2 + "\"" + "does not have a match in our records!");
                    break;
                }

            }
            Console.ReadLine();
            ///////////////////////////////////////PART 6////////////////////////////////////

            List<string> animals33 = new List<string>() { "MONKEY", "TIGER", "ELEPHANT", "TIGER", "SNAKE", "LION" }; //string list
            Console.WriteLine("Hi. Please enter your favourite animal name"); //text output to console
            string animallist = Console.ReadLine(); //declares variable from user input
            string animallist2 = animallist.ToUpper(); // capitalize user input to avoid capital leter errors



            foreach (string animal11 in animals33)//loop to check strings in list
            {
                if (animal11 == animallist2) //if statement if input maches list 
                {

                    Console.WriteLine("Your animal is in the zoo. Crate nr: " + animals33.IndexOf(animal11)); //console output with index of list matching input

                    
                }
                if (animal11 != animallist2)
                {
                    Console.WriteLine("Your favourite animal is not in crate nr:"  + animals33.IndexOf(animal11));

                    

                }

            }
            Console.ReadLine();


        }

    }
    
}

    

