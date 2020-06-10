using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods4
{
    public class MyClass
    {
        public static void MyMethod(int i, int j)
        {
            i = i + 5;
            j = i * j;
            Console.WriteLine(j);
        }
    }
}
