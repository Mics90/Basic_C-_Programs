using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_I0_Asignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your phone number?");
            string answer = Console.ReadLine();
            Console.WriteLine("You wrote: " + answer);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Nauris\Desktop\Nauris_studijas\C_SHARP\Basic_C-_Programs\logs\log.txt", true))
            {
                file.WriteLine(answer);

            }
            Console.ReadLine();
        }
    }
}
