using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            try
            {
                Console.WriteLine("Please enter two numbers. (Entering a second number is optional. Default is 0)");
                Console.WriteLine("First number:");
                int numOne;
                numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Second number:");
                string numTwo = Console.ReadLine();

                if (numTwo == "")
                {
                    Console.WriteLine(MyClass.MyMethod(numOne));
                }
                else
                {
                    Console.WriteLine(MyClass.MyMethod(numOne, Convert.ToInt32(numTwo)));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
