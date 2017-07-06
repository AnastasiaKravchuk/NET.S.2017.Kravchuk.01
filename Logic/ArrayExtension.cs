using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    /// <summary>
    /// Class QuickSortLibrary is the array extengence 
    /// class: it contains methods of QuickSort realisation. ///
    /// </summary>
    public class ArrayExtension
    {
        /// <summary>
        /// Method find an index of the number, which separates 
        /// array in two equal parts (in sum of elements)
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int FindIndexOfEqualSum(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }
            int n = arr.Length;
            if (n > 1000)
            {
                throw new ArgumentOutOfRangeException();
            }
            int i; int sumLeft = 0; int sumRight = 0;
            int sumTotal = arr.Sum();
            for (i = 0; i < n - 1; i++)
            {
                sumLeft += arr[i];
                sumRight = sumTotal - sumLeft - arr[i + 1];

                if (sumLeft == sumRight)
                {
                    return i + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// The wrapping method for QuickSort.
        /// </summary>
        /// <param name="arr"></param>
        public static void QuickSortWrapper(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException();
            }
            QuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Main method to sort the array using QuickSort algorithm
        /// </summary>
        /// <param name="arr">The array needed to be sorted</param>
        /// <param name="first">The first element of sub-array</param>
        /// <param name="last">>The last element of sub-array</param>
        private static void QuickSort(int[] arr, int first, int last)
        {
            if (arr == null)
                throw new ArgumentNullException();

            int pivot = arr[(last + first) / 2];
            int i = first;
            int j = last;
            while (i <= j)
            {
                while (arr[i] < pivot) i++;
                while (arr[j] > pivot) j--;
                if (i <= j) { Swap(ref arr[i], ref arr[j]); j--; i++; }
            }
            if (i < last)
            {
                QuickSort(arr, i, last);
            }
            if (first < j)
            {
                QuickSort(arr, first, j);
            }
        }

        /// <summary>
        /// The wrapping method for MergeSort.
        /// </summary>
        /// <param name="arr"></param>
        public static void MergeSortWrapper(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            MergeSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// MergeSort is an efficient, general-purpose, comparison-based sorting algorithm.
        /// </summary>
        /// <param name="array">The array needed to be sorted</param>
        /// <param name="first">The first element of sub-array</param>
        /// <param name="last">The last element of sub-array</param>
        private static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                MergeSort(array, left, middle);
                MergeSort(array, middle + 1, right);
                Merge(array, left, middle, right);
            }
        }

        /// <summary>
        /// Merge merges the two sorted sub-arrays into one. 
        /// </summary>
        /// <param name="array">The array needed to be sorted</param>
        /// <param name="first">The first element of sub-array</param>
        /// <param name="middle">The middle element of sub-array</param>
        /// <param name="last">The last element of sub-array</param>
        private static void Merge(int[] array, int left, int middle, int right)
        {
            int[] helper = new int[array.Length];

            for (int i = left; i <= right; i++)
            {
                helper[i] = array[i];
            }

            int helperLeft = left,
              helperRight = middle + 1,
              current = left;

            while (helperLeft <= middle && helperRight <= right)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[current] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[current] = helper[helperRight];
                    helperRight++;
                }
                current++;
            }

            if (helperLeft > middle)
            {
                for (; helperRight <= right; helperRight++, current++)
                {
                    array[current] = helper[helperRight];
                }
            }
            else
            {
                for (; helperLeft <= middle; helperLeft++, current++)
                {
                    array[current] = helper[helperLeft];
                }
            }
        }

        /// <summary>
        /// Method Swap exchanges two elements in array
        /// </summary>
        /// <param name="a">The first element to be swapped</param>
        /// <param name="b">The second element to be swapped</param>
        private static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}