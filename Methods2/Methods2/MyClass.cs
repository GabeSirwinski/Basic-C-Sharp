using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    public class MyClass
    {
        public static int Addition(int i)
        {
            i = i + 5;
            i = i * 3;
            return i;
        }

        public static decimal Addition(decimal i)
        {
            i = i * 3;
            i = i / 2;
            return i;
        }

        public static int Addition(string h)
        {
            int j = Convert.ToInt32(h) * 10;
            return j;
        }
    }
}
