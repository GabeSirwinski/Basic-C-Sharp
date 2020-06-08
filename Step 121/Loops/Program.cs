using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Using a While loop:");
            
            bool isGuessed = false;

            while (!isGuessed)
            {
                Console.WriteLine("What is your favorite fruit?");
                string fruit = Console.ReadLine();
                switch (fruit)
                {
                    case "Apples":
                        Console.WriteLine("Apples are good, but not correct. Try again.");
                        break;
                    case "Bananas":
                        Console.WriteLine("Unfortunately, that is wrong. Try again.");
                        break;
                    case "Watermelon":
                        Console.WriteLine("Nice choice!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine(fruit + " is not correct. Sorry :(");
                        break;
                }
            }
            Console.WriteLine("Using a Do While loop:");
            Console.WriteLine("What is your favorite fruit?");
            string fruity = Console.ReadLine();

            bool correctFruit = fruity == "Watermelon";

            do
            {
                switch (fruity)
                {
                    case "Apples":
                        Console.WriteLine("Sorry, Apples is not the right answer.");
                        Console.WriteLine("What is your favorite fruit?");
                        fruity = Console.ReadLine();
                        break;
                    case "Bananas":
                        Console.WriteLine("That is not correct.");
                        Console.WriteLine("What is your favorite fruit?");
                        fruity = Console.ReadLine();
                        break;
                    case "Watermelon":
                        Console.WriteLine("You are correct!");
                        correctFruit = true;
                        break;
                    default:
                        Console.WriteLine(fruity + " is not correct. Try again.");
                        Console.WriteLine("What is your favorite fruit?");
                        fruity = Console.ReadLine();
                        break;

                }
            }
            while (!correctFruit);
            Console.Read();
        }
    }
}
