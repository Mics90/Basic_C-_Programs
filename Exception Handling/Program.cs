using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Exception_Handling
{
   class Program
    {
        static void Main()

        {

            
            try
            {
                bool ValidAge = false;
                int YourAge = 0;
                while (!ValidAge)
                {
                    Console.WriteLine("Please type in your age");
                    ValidAge = int.TryParse(Console.ReadLine(), out YourAge);
                    if (!ValidAge) throw new Exception();
                    if (YourAge<0)
                    {
                        throw new NegativeException();
                        Console.ReadLine();
                        return;

                    }
                    if (YourAge == 0)
                    {
                        throw new ZeroException();
                        Console.ReadLine();
                        return;

                    }


                }
                Double YearOfBirth = Convert.ToDouble(DateTime.Now.Year) - YourAge;
                Console.WriteLine("You was born in: " + YearOfBirth);
                Console.ReadLine();
            }

            
            
            
            catch (NegativeException)
            {
                
                Console.WriteLine("Please enter positive numbers");
                Console.ReadLine();
                return;
            }
            catch (ZeroException)
            {

                Console.WriteLine("0 is not a valid age!");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Ops something went wrong!");
                Console.ReadLine();
                return;
            }
            
           
        }
    }
}
