using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            const int hoursInDay = 24;
            Console.WriteLine("There are {0} hours in a day.",hoursInDay);
            Console.ReadLine();
            Employee employee1 = new Employee(1, "John", 25);
            Employee employee2 = new Employee(2, "Jack");

            List<Employee> employees = new List<Employee>();
            employees.Add(employee1);
            employees.Add(employee2);

            var notSureWhatThisIs = employees.Where(x => x.ID < 3); // Example of using var

            foreach (Employee employee in notSureWhatThisIs)
            {
                Console.WriteLine("Name: {0}.\nID: {1}.\nWage: ${2}/hour.\n", employee.Name, employee.ID, employee.hourlyWage);
            }
            Console.ReadLine();

        }
    }
}
