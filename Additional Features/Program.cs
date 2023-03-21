using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            const string question = "Please give me a number: ";
            Console.WriteLine("{0}", question);
            int x = Convert.ToInt32(Console.ReadLine());



            var answer = new Sum();




            Console.WriteLine("We did some math with your number: " + x + " and result is: ");
            Console.WriteLine(answer.x + answer.y + x );
            
            Console.ReadLine();
        }
        
    }
}
