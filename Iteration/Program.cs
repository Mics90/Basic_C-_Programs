using System;
using System.Collections.Generic;


namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] testscores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testscores.Length; i++)
            //{
            //    if (testscores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testscores[i]);
            //    }
            //}
            //Console.ReadLine();

            string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                    Console.Read();
                }
            }
        }
    }
}
