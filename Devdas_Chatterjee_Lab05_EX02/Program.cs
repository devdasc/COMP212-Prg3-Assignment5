using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devdas_Chatterjee_Lab05_EX02
{
    class Program
    {
        static void Main(string[] args)
        {

            // create arrays of int, double and char
            int[] intArray = { 1, 2, 3, 4, 5, 6, 7, 8 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6, 7.7, 8.8, 9.9 };
            char[] charArray = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','j','k' };

            Console.Write("\n");
            Console.WriteLine("---------------Int Array-----------------------------------");
            Console.Write("Array intArray contains: ");
            DisplayArray(intArray); // pass an int array argument

            Console.Write("Enter the lower index: ");
            int lowIndex = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the higher index: ");
            int highIndex = Convert.ToInt32(Console.ReadLine());

            Console.Write("Array intArray contains from index{0} to {1}: ",lowIndex,highIndex);
            DisplayArray(intArray,lowIndex, highIndex); // pass an int array argument with index 2 to 5

            Console.Write("Enter the lower index: ");
            int lowIndex2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the higher index: ");
            int highIndex2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Array intArray contains from index{0} to {1}: ", lowIndex2, highIndex2);
            DisplayArray(intArray, lowIndex2, highIndex2); // pass an int array argument with index 5 and 9

            Console.Write("Enter the lower index: ");
            int lowIndex3 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the higher index: ");
            int highIndex3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Array intArray contains from index{0} to {1}: ", lowIndex3, highIndex3);
            DisplayArray(intArray, lowIndex3, highIndex3); // pass an int array argument with index 6 and 6

            Console.WriteLine("\n-------------------------Double Array----------------------\n");

            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray); // pass a double array argument

            Console.Write("Enter the lower index: ");
            int lowIndex4 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the higher index: ");
            int highIndex4 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Array intArray contains from index{0} to {1}: ", lowIndex4, highIndex4);
            DisplayArray(doubleArray, lowIndex4, highIndex4); // pass a double array argument with index 4 and 6

            Console.Write("Enter the lower index: ");
            int lowIndex5 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the higher index: ");
            int highIndex5 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Array intArray contains from index{0} to {1}: ", lowIndex5, highIndex5);
            DisplayArray(doubleArray, lowIndex5, highIndex5); // pass a double array argument with index 4 and 10

            Console.Write("Enter the lower index: ");
            int lowIndex6 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the higher index: ");
            int highIndex6 = Convert.ToInt32(Console.ReadLine());


            Console.Write("Array intArray contains from index{0} to {1}: ", lowIndex6, highIndex6);
            DisplayArray(doubleArray, lowIndex6, highIndex6); // pass an int array argument with index 7 and 7

            Console.WriteLine("\n--------------------------Char Array-----------------------\n");

            Console.Write("Array charArray contains: ");
            DisplayArray(charArray); // pass a char array argument

            Console.Write("Array charArray contains from index 4 to 7: ");
            DisplayArray(charArray, 4, 7); // pass a double array argument with index 4 and 7

            Console.Write("Array charArray contains from index 7 to 11: ");
            DisplayArray(charArray, 7, 11); // pass a double array argument with index 7 and 11

            Console.Write("Array charArray contains from index 7 to 7: ");
            DisplayArray(charArray, 7, 7); // pass an int array argument with index 7 and 7
            Console.ReadKey();

        }

        // Generic method for output array of all types                           
        private static void DisplayArray<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine();
        }
        // Overloaded Generic method
        private static void DisplayArray<T>(T[] inputArray, int lowIndex, int highIndex)
        {

            try
            {
                if (lowIndex >= highIndex)
                {
                    
                    throw new ArgumentException("lowIndex cannot be greater than or equal to highIndex");
                }
                else if (lowIndex > inputArray.Length)
                {
                    throw new System.ArgumentException("lowIndex is out of range");
                }
                else if (highIndex > inputArray.Length)
                {
                    throw new System.ArgumentException("highIndex is out of range");
                }
                else
                {
                    for (int i = lowIndex; i <= highIndex; i++)
                    {
                        Console.Write($"{inputArray[i]} ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {

                Console.Write(e.Message);
                Console.WriteLine();
            }
        }
    }
}
