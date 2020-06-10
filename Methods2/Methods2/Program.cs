using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass HelloWorld = new MyClass();

            Console.WriteLine(MyClass.Addition(3));
            Console.ReadLine();

            Console.WriteLine(MyClass.Addition(3.45m));
            Console.ReadLine();

            Console.WriteLine(MyClass.Addition("3"));
            Console.ReadLine();
        }
    }
}
