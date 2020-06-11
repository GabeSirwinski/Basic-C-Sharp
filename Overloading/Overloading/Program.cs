using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();
            Employee employee3 = new Employee();
            employee1.Id = 10;
            employee2.Id = 20;
            employee3.Id = 10;

            Console.WriteLine(employee1 == employee2);
            Console.WriteLine(employee1 == employee3);
            Console.ReadLine();
        }
    }
}
