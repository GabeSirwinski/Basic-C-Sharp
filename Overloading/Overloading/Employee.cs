using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }

        public static bool operator== (Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            if (emp1.Id == emp2.Id)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
