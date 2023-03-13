using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()

        {
            Console.WriteLine("Name: " + firstName + " Surname: " + lastName);
        }
        public void Quit()//Interface Assignment
        {
            Console.WriteLine("I " + firstName + " " + lastName + " Quit!");// Interface Assignment
        }

    }
}
