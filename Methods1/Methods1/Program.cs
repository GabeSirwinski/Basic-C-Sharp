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
            nums.NumOne = Convert.ToInt32(Console.ReadLine());
            nums = Numbers.Multiply(nums);
            Console.WriteLine("Times 5: " + nums.NumOne);
            nums = Numbers.Add(nums);
            Console.WriteLine("Plus 5: " + nums.NumOne);
            nums = Numbers.Subtract(nums);
            Console.WriteLine("Minus 15: " + nums.NumOne);
            Console.ReadLine();
        }
        
    }
}
