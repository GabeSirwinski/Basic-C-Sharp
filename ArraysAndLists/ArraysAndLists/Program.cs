using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] strArray = { "Apple", "Banana", "Pear", "Peach", "Watermelon" };
        bool isValid = false;
        while (!isValid)
        {
            Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-4)");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice >= 0 && choice <= 4)
            {
                Console.WriteLine("\nYou chose: " + strArray[choice] + "\n");
                isValid = true;
            }
            else
            {
                Console.WriteLine("Index entered is not valid.");
            }
        }

        int[] intArray = { 12, 23, 34, 45, 56 };
        bool isValid1 = false;
        while (!isValid1)
        {
            Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-4)");
            int choice1 = Convert.ToInt32(Console.ReadLine());
            if (choice1 >= 0 && choice1 <= 4)
            {
                Console.WriteLine("\nYou chose: " + intArray[choice1] + "\n");
                isValid1 = true;
            }
            else
            {
                Console.WriteLine("Index entered is not valid.");
            }
        }


        List<string> strList = new List<string>();
        strList.Add("Apples");
        strList.Add("Pears");
        strList.Add("Strawberries");
        strList.Add("Blackberries");
        strList.Add("Watermelon");
        strList.Add("Peaches");

        bool isValid2 = false;
        while (!isValid2)
        {
            Console.WriteLine("Please enter an index from the list: \n(Whole number between 0-5)");
            int choice2 = Convert.ToInt32(Console.ReadLine());
            if (choice2 >= 0 && choice2 <= 5)
            {
                Console.WriteLine("\nYou chose: " + strList[choice2] + "\n");
                isValid2 = true;
            }
            else
            {
                Console.WriteLine("Index entered is not valid.");
            }
        }
        Console.ReadLine();



        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[4]);
        //Console.ReadLine();

        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

        //int[] numArray2 = { 5, 2, 10, 200, 5000, 4 };

        //numArray2[5] = 650;

        //Console.WriteLine(numArray2[5]);
        //Console.ReadLine();
    }
}

