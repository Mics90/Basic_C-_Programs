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
            Sum s = new Sum();
            var answer = s.getSum() + x;
            Console.WriteLine(x +"+"+ s.getSum() + " equals: " + answer);
            Console.ReadLine();
        }
        
    }
}
