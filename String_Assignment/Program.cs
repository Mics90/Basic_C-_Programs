using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
           

            string one = "Hello!"; //asiigning 3 strings
            string two = "Today is Wednesday.";
            string three = "It will be a great day!";

            


            Console.WriteLine(one + "\n" + two + "\n" + three);//Concatenate three strings
            

            // string converted to Upper case
            string one2 = one.ToUpper();

            Console.WriteLine(one2);//outputs string with all upercase letters

            StringBuilder sb = new StringBuilder("\t Appended Paragraph example! \n "); // new stringbuilder
            sb.Append(" \n ");//append stringbuilder
            sb.AppendLine("This is appended line \n");
            sb.AppendLine("And this is one more appended line \n");
            sb.AppendLine("And this is one more appended line \n");
            sb.AppendLine("And this is one more appended line \n");
            sb.AppendLine("And this is one more appended line \n");
            sb.AppendLine("And this is last appended line! \n");
            sb.AppendLine("Thank You and have a nice day!");
            Console.WriteLine(sb);// output of stringbuilder
            Console.ReadLine();


        }
    }
}
