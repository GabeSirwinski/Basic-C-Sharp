using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Employee<T>
    {
        public List<T> Things { get; set; }

        public static void PrintAll(Employee<T> employee)
        {
            foreach (T thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
