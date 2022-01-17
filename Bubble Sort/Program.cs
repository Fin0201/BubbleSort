using System;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bubble sort algorithm
            int[] numberArray = { 7, 34, 16, 91, 37, 16, 10, 67, 7, 12, 12, 1, 5, 91 }; //The array that will be sorted

            numberArray = numberArray.Distinct().ToArray(); //Removes duplicate values
            int arrayLength = numberArray.Length; //Calculates the length of the array.



            for (int i = 0; i < arrayLength; i++) //Loops through the following for loop
            {
                for (int j = 0; j < arrayLength - 1; j++) //Loops through the array for each value in it 
                {
                    int x = numberArray[j]; //Stores the current value in x
                    int y = numberArray[j + 1]; //Stores the next value in y

                    if (y > x) //Compares the two values. If true, it will then swap them.
                    {
                        numberArray[j] = y;
                        numberArray[j + 1] = x;
                    }
                }
            }





            //Displaying the sorted array
            Console.WriteLine(string.Join(", ", numberArray));
        }
    }
}