using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step_90
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            float income1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hours1 = Convert.ToSingle(Console.ReadLine());
            float person1 = income1 * hours1 * 52;
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            float income2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            float hours2 = Convert.ToSingle(Console.ReadLine());
            float person2 = income2 * hours2 * 52;
            Console.WriteLine("Annual salary of Person 1: " + person1.ToString("c2"));
            Console.WriteLine("Annual salary of Person 2: " + person2.ToString("c2"));
            bool compareSalary = person1 > person2;
            Console.WriteLine("Does Person 1 make more than Person 2? " + compareSalary);
            Console.ReadLine();
        }
    }
}
