using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string number = Console.ReadLine();
            string filePath = "C:\\Users\\Gabri\\Desktop\\text.txt"; // This will be the file that is written to / read from
            File.WriteAllText(filePath, number); // This will overwrite any text in the file
            Console.WriteLine("The contents of text.txt: " + File.ReadAllText(filePath));
            using (StreamWriter file = new StreamWriter(filePath, true)) // This will append the number to the existing text
            {
                file.WriteLine(number);
            }
            Console.WriteLine("The contents of text.txt after the number is appended: " + File.ReadAllText(filePath));
            Console.ReadLine();
        }
    }
}
