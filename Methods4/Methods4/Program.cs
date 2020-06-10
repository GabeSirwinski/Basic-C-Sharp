using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();

            MyClass.MyMethod(4, 5);

            MyClass.MyMethod(i: 4, j: 5);
            Console.ReadLine();
        }
    }
}
