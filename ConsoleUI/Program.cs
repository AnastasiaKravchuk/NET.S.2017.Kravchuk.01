using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Logic.ArrayExtension;

namespace ConsoleUI
{
    /// <summary>
    /// Main class of the quicksort program.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Method PrintArray() is a method used 
        /// to display the array generated in the program
        /// </summary>
        /// <param name="arr">Argument of PrintArray() method</param>
        public static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(" " + item.ToString());
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Method CreateArray() is a method used 
        /// to generate the array of a given size
        /// </summary>
        /// <param name="n">Argument of CreateArray() method</param>
        /// <returns></returns>
        public static int[] CreateArray(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
            return array;
        }

        /// <summary>
        /// Method Main() is program's
        /// entry point
        /// </summary>
        /// <param name="args">Argument of Main() method</param>
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 45, 8, 9, 90, 10, 11 };

            Console.WriteLine("Enter size of array: ");
            Console.WriteLine();
            int n = int.Parse(Console.ReadLine());
            int[] arr = CreateArray(n);
            int[] arr1 = arr;
            Console.WriteLine("Initialized array: ");
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted array (Quick Sort): ");
            QuickSortWrapper(arr);
            PrintArray(arr);
            Console.WriteLine();
            Console.WriteLine("Sorted array (Merge Sort): ");
            //int[] arr1 = CreateArray(n);
            MergeSortWrapper(arr1);
            PrintArray(arr1);

        }
    }
}