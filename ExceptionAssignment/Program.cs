using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                

                int[] numbers = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            Console.WriteLine("Please pick a number.");
            int userNumber = Convert.ToInt32(Console.ReadLine());
           
                for (int k = 0; k < numbers.Length; k++)
                {


                    int result = numbers[k] / userNumber;
                    Console.WriteLine(numbers[k] + " divided by " + userNumber + " equals to " + result);


                }
            }





            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please dont use zero!");
                goto start;


            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please use numbers only!");
                goto start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto start;

            }
            finally
            {
                Console.ReadLine();
            }

            
        }
        
        
    }
    

}
