using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What state are you in?");
            string state = Console.ReadLine();
            Console.WriteLine("What city are you in?");
            string city = Console.ReadLine();
            string line = "Your name is " + name + " and you are in " + city + ", " + state + ".";
            Console.WriteLine(line.ToUpper());

            StringBuilder hello = new StringBuilder();

            hello.Append("This is the first sentence.");
            hello.Append("\nThis is the second.");
            hello.Append("\nThis is the third senctence.");
            hello.Append("\nThis is the end of the paragraph.");

            Console.WriteLine(hello);
            Console.Read();

        }
    }
}
