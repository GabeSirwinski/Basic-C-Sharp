using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int> { 45, 58, 96, 29, 83, 25 };
            try
            {
                Console.WriteLine("Please enter a numbner:");
                int numOne = Convert.ToInt32(Console.ReadLine());
                foreach (int num in intList)
                {
                    Console.WriteLine(num / numOne);
                }
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter a number.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is not possible.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Now on to the next part of the program");
            }
            Console.WriteLine("This is outside of the try/catch.");
            Console.ReadLine();


            //try
            //{
            //    Console.WriteLine("Pick a number:");
            //    int numOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Pick a second number.");
            //    int numTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numThree = numOne / numTwo;
            //    Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
            //    Console.ReadLine();
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Please type a whole number.");
            //    return;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Dividing by zero is not possible.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.ReadLine();
            //}
            
        }
    }
}
