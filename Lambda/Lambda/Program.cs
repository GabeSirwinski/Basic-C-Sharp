using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            List<String> fName = new List<string>() { "Joe", "Jack", "John", "Frank", "Fred" };
            List<String> lName = new List<string>() { "Wells", "Wilson" };
            int id = 1;

            foreach (string fname in fName)
            {
                foreach (string lname in lName)
                {
                    Employee employee = new Employee();
                    employee.Id = id;
                    employee.FirstName = fname;
                    employee.LastName = lname;
                    employees.Add(employee);
                    id++;
                }
            }

            //This is just to display all employees

            foreach (Employee employee in employees)
            {
                Console.WriteLine("ID: " + employee.Id + " Name: " + employee.FirstName + " " + employee.LastName);
            }

            Console.WriteLine("\n");

            //Using a foreach loop instead of Lambda 'Where'

            List<Employee> JoeList = new List<Employee>();
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    JoeList.Add(employee);
                }
            }
            foreach (Employee joe in JoeList)
            {
                Console.WriteLine("ID: " + joe.Id + " Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\n");

            //Now Using Lambda

            List<Employee> JoeList1 = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee joe in JoeList1)
            {
                Console.WriteLine("ID: " + joe.Id + " Name: " + joe.FirstName + " " + joe.LastName);
            }

            Console.WriteLine("\n");

            // Id greater than 5

            List<Employee> ByID = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee ID in ByID)
            {
                Console.WriteLine("ID: " + ID.Id + " Name: " + ID.FirstName + " " + ID.LastName);
            }


            Console.ReadLine();
        }
    }
}
