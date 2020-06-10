using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
     static class MyClass
    {
        public static void MyMethod(int i, out int j)
        {
            j = i / 2;
        }

        public static void MyMethod(int i, int j, out int k, out int l)
        {
            k = j - i;
            l = j + i;
        }
    }
}
