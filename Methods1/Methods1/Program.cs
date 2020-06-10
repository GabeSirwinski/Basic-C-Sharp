using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers nums = new Numbers();
            Console.WriteLine("Please enter a number: ");
            int selectedNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(selectedNum + " times 5 = " + Numbers.Multiply(selectedNum));
            Console.WriteLine(selectedNum + " plus 5 = " + Numbers.Add(selectedNum));
            Console.WriteLine(selectedNum + " minus 15 = " + Numbers.Subtract(selectedNum));
            Console.ReadLine();
        }
        
    }
}
