using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst
{
    class Employee
    {
        public int Id { get; set; }
        public  string Name { get; set; }
        public int Salary { get; set; }
        public string JobTitle { get; set; }

        public static List<String> displayEmployees()
        {
            var list = new List<string>();
            using (var db = new CodeFirstContext())
            {
                var emp = db.Employees.ToList();
                foreach (var employee in emp)
                {
                    list.Add("ID: " + employee.Id + " | " + employee.Name + " | $" + employee.Salary + ".00 | " + employee.JobTitle);
                }
            }
            return list;
        }

        public static List<Employee> getAll()
        {
            var employees = new List<Employee>();
            using (var db = new CodeFirstContext())
            {
                var e = db.Employees.ToList();
                foreach (Employee em in e)
                {
                    employees.Add(em);
                }
            }
            return employees; 
        }

        public static string total()
        {
            return Employee.displayEmployees().Count.ToString();
        }
        public static string totalSalary()
        {
            var list = Employee.getAll();
            int total = 0;
            foreach (Employee employee in list)
            {
                total += employee.Salary;
            }
            return total.ToString();
        }
        
}

   
    
}
