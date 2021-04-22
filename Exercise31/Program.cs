using System;

namespace Exercise31
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            while (repeat)
            {
                //Create an array with 5 numbers (given in the instructions).
                int[] myArray = new int[] { 2, 8, 0, 24, 51 };
                //Only numbers 0-4 will return a value given the size of our array.
                Console.WriteLine("Enter an index (0-4) of the array");
                string val = Console.ReadLine();
                int index = int.Parse(val);
                int number = myArray[index];
                Console.WriteLine($"The number {number} is in index {index}");

                Console.WriteLine("Would you like to input another index? y/n");
                //No matter if capital or lower case is used, a Y/y will return bool true
                string answer = Console.ReadLine().ToLower();

                if (answer == "y")
                {
                    repeat = true;
                }
                //Any answer other than Y/y will return bool false, and the loop will terminate.
                else
                {
                    Console.WriteLine("Goodbye.");
                    repeat = false;
                }
            }
        }
    }
}
