using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (Enter 'true' or 'false')");
            bool hasDUI = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = Convert.ToInt32(Console.ReadLine());
            bool isQualified = age > 15 && hasDUI == false && speedingTickets <= 3;
            Console.WriteLine("Is Qualified? " + isQualified);
            Console.Read();
        }
    }
}
