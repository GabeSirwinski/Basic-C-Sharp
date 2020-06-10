using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods1
{
    public class Numbers
    {
        public int NumOne { get; set; }
        public static int Multiply(int num)
        {
            num = num * 5;
            return num;
        }
        public static int Add(int num)
        {
            num = num + 5;
            return num;
        }
        public static int Subtract(int num)
        {
            num = num - 15;
            return num;
        }
    }

   
}
