﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_methods_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Math mathObject = new Math();
            int a = mathObject.Integer(10, 6);
            Console.WriteLine("10 + 6 is : " + a);

            decimal b = mathObject.Decimal(90, 22);
            Console.WriteLine("90/20  division result is : " + b);


            int c = mathObject.String("9999", "666");
            Console.WriteLine("9999 - 666 result is : " + c);
            Console.Read();
        }
    }
}
