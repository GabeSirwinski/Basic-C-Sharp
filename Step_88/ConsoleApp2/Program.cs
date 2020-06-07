using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            double mul50 = Convert.ToDouble(Console.ReadLine());
            double answer1 = mul50 * 50;
            Console.WriteLine("Times 50: " + answer1.ToString());

            Console.WriteLine("Enter number:");
            double add25 = Convert.ToDouble(Console.ReadLine());
            double answer2 = add25 + 25;
            Console.WriteLine("Plus 25: " + answer2.ToString());

            Console.WriteLine("Enter number:");
            double div12 = Convert.ToDouble(Console.ReadLine());
            double answer3 = div12 / 12.5;
            Console.WriteLine("Divided by 12.5: " + answer3.ToString());

           Console.WriteLine("Enter number:");
           double grThan50 = Convert.ToDouble(Console.ReadLine());
            bool answer4 = grThan50 > 50;
            Console.WriteLine("Greater than 50? " + answer4);

            Console.WriteLine("enter number:");
            double rem7 = Convert.ToDouble(Console.ReadLine());
            double answer5 = rem7 % 7;
            Console.WriteLine("Remainder after divided by 7: " + answer5.ToString());
            Console.ReadLine();
        }
    }
}
