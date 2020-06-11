using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using Strings

            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string>() { "Hello", "How", "Are", "You?" };
            Employee<string>.PrintAll(employee1);

            //Using Integers

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int>() { 1, 2, 3, 4, 5, 6 };
            Employee<int>.PrintAll(employee2);

            Console.ReadLine();
        }
    }
}
