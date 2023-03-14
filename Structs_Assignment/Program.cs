using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Amount = new Number
            {
                Amount = 1.23m
            };
            Console.WriteLine("Amount is " + Amount.Amount);
            Console.Read();
        }
    }
}
