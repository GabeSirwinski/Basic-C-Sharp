using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // part one

            string[] words = { "hello", "apple", "hotdog", "greg" };
            Console.WriteLine("please enter some text:");
            string text = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i] + text;
            }
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadLine();

            //part two and three

            while (6 < 7)
            {
                Console.WriteLine("hello!");
                break; //without this it will run forever
            }
            Console.ReadLine();

            //part four

            int counter = 0;

            while (counter < 5)
            {
                counter += 1;
                Console.WriteLine(counter);
            }
            Console.ReadLine();

            //part five

            int counter1 = 0;

            while (counter1 <= 5)
            {
                counter1 += 1;
                Console.WriteLine(counter1);
            }
            Console.ReadLine();

            // part six, seven, eight

            List<string> fruits = new List<string>() { "apples", "pears", "strawberries", "peaches", "bananas", "watermelon" };
            bool validsearch = false;
            while (!validsearch)
            {
                Console.WriteLine("enter a fruit:");
                string search = Console.ReadLine();
                int counter2 = 0;
                for (int i = 0; i < fruits.Count; i++)
                {
                    if (fruits[i] == search)
                    {
                        Console.WriteLine("index: " + i + " value: " + search);
                        counter2 += 1;
                    }
                }
                if (counter2 == 0)
                {
                    Console.WriteLine("fruit not found. please try again.");
                }
                else
                {
                    validsearch = true;
                }
            }

            // part nine & ten

            List<string> fruits1 = new List<string>() { "apples", "apples", "apples", "pears", "strawberries", "peaches", "bananas", "watermelon" };
            bool validsearch1 = false;
            while (!validsearch1)
            {
                Console.WriteLine("enter a fruit:");
                string search = Console.ReadLine();
                int counter2 = 0;
                for (int i = 0; i < fruits1.Count; i++)
                {
                    if (fruits1[i] == search)
                    {
                        Console.WriteLine("index: " + i + " value: " + search);
                        counter2 += 1;
                    }
                }
                if (counter2 == 0)
                {
                    Console.WriteLine("fruit not found. please try again.");
                }
                else
                {
                    validsearch1 = true;
                }
            }

            List<string> fruits2 = new List<string>() { "Apples", "Apples", "Apples", "Pears", "Pears", "Strawberries", "Apples", "Peaches", "Bananas", "Watermelon" };

            int counter4 = 0;

            foreach (string fruit in fruits2)
            {
                for (int i = 0; i < fruits2.Count; i++)
                {
                    if (fruits2[i] == fruit)
                    {
                        counter4 += 1;
                    }
                }
                if (counter4 > 1)
                {
                    Console.WriteLine(fruit + " appears more than once in the list");
                }
                else
                {
                    Console.WriteLine(fruit);
                }
                counter4 = 0;
            }
            Console.ReadLine();

        }  
    }
}
