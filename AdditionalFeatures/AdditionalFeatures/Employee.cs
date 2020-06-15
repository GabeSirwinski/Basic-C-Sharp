using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalFeatures
{
    public class Employee
    {
        public Employee(int id, string name) : this(id, name, 20)
        {
        }
        public Employee(int id, string name, int wage)
        {
            ID = id;
            Name = name;
            hourlyWage = wage;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int hourlyWage { get; set; }
    }
}
