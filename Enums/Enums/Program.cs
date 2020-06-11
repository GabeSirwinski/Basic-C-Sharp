using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validDay = false;
            while (!validDay)
            {
                Console.WriteLine("Please enter the current day of the week: ");
                string input = Console.ReadLine();
                bool isNumeric = int.TryParse(input, out _);
                if (!isNumeric)
                {
                    try
                    {
                        DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), input);
                        Console.WriteLine("Thanks for letting me know that today is " + day + "!");
                        validDay = true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Please enter an actual day of the week.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a string.");
                }
            }
            Console.ReadLine();
        }
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
