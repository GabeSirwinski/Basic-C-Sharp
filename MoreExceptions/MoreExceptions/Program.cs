using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAge = false;
            while (!validAge)
            {
                try
                {
                    Console.WriteLine("Please enter your age: ");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age == 0)
                    {
                        throw new ArgumentOutOfRangeException("Zero not valid");
                    }
                    else if (age < 0)
                    {
                        throw new ArgumentOutOfRangeException("Negative number not valid");
                    }
                    int yearBorn = 2020 - age;
                    Console.WriteLine("You were born in {0}.", yearBorn);
                    Console.ReadLine();
                    validAge = true;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.ParamName + ". Please enter a valid age.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Something went wrong. Please try again.");
                }
            }
            
            
        }
    }
}
