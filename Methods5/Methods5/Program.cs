using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            //The below code will not work, as the class 'MyClass' is no longer declared public (now static per instructions).
            //MyClass myClass = new MyClass();

            Console.WriteLine("Please enter a number:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo;
            MyClass.MyMethod(i: numOne, out numTwo);
            Console.WriteLine("Number divided by two is: " + numTwo);

            int numThree;
            int numFour;
            MyClass.MyMethod(i: numOne, j: numTwo, out numThree, out numFour);
            Console.WriteLine("Quotient minus dividend: " + numThree);
            Console.WriteLine("Quotient plus dividend: " + numFour);
            Console.ReadLine();

        }
    }
}
