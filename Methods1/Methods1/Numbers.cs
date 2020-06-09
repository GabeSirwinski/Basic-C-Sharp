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
        public static Numbers Multiply(Numbers nums)
        {
            nums.NumOne = nums.NumOne * 5;
            return nums;
        }
        public static Numbers Add(Numbers nums)
        {
            nums.NumOne = nums.NumOne + 5;
            return nums;
        }
        public static Numbers Subtract(Numbers nums)
        {
            nums.NumOne = nums.NumOne - 15;
            return nums;
        }
    }

   
}
