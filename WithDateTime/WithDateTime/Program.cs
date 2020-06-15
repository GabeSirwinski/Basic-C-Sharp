using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime current = new DateTime();
            current = DateTime.Now;
            Console.WriteLine("Current DateTime: " + current + "\nPlease enter a number: ");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Current DateTime plus {0} hours = {1}.", hours, current.AddHours(hours));
            Console.ReadLine();
        }
    }
}
