using System;
using  static Logic.ArrayExtension;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic.Tests
{
    [TestClass]
    public class ArrayExtensionTests
    {
        [TestMethod]
        public void QuickSort_PositiveArray_ReturnTrue()
        { 

            int[] arr = new int[]{ 51, 22, 3, 14,  4, 6};
            int[] res = new int[]{ 3, 4, 6, 14, 22, 51};
            QuickSortWrapper(arr);

            CollectionAssert.AreEqual(arr,res);
        }

        [TestMethod]
        public void QuickSort_EmptyArray_ReturnTrue()
        {
            int[] arr = new int[10];
            int[] res = new int[10];
            QuickSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_NullArray_ReturnedException()
        { 
            int[] arr = null;

            QuickSortWrapper(arr);
        }

        [TestMethod]
        public void QuickSort_NegativeArray_ReturnTrue()
        {
            int[] arr = new int[] { -51, -2, -23, -3, -14, -4, -61 };
            int[] res = new int[] { -61, -51, -23, -14, -4, -3, -2 };
            QuickSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        public void QuickSort_MixedArray_ReturnTrue()
        {
            int[] arr = new int[] { -51, 2, -23, -3, 14, -4, 61 };
            int[] res = new int[] { -51, -23, -4, -3, 2, 14, 61 };
            QuickSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        public void MergeSort_MixedArray_ReturnTrue()
        {
            int[] arr = new int[] { -51, 2, -23, -3, 14, -4, 61 };
            int[] res = new int[] { -51, -23, -4, -3, 2, 14, 61 };
            MergeSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        public void MergeSort_PositiveArray_ReturnTrue()
        {

            int[] arr = new int[] { 51, 22, 3, 14, 4, 6 };
            int[] res = new int[] { 3, 4, 6, 14, 22, 51 };
            MergeSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        public void MergeSort_NegativeArray_ReturnTrue()
        {
            int[] arr = new int[] { -51, -2, -23, -3, -14, -4, -61 };
            int[] res = new int[] { -61, -51, -23, -14, -4, -3, -2 };
            MergeSortWrapper(arr);

            CollectionAssert.AreEqual(arr, res);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergekSort_NullArray_ReturnedException()
        {
            int[] arr = null;

            MergeSortWrapper(arr);
        }
    }
}
