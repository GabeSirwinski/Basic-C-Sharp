using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods3
{
    class MyClass
    {
        public static int MyMethod(int i, int j = 0)
        {
            i = i * j;
            return i;
        }
    }
}
