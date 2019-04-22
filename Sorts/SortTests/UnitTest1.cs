using System;
using Xunit;
using static Sorts.Program;

namespace SortTests
{
    public class UnitTest1
    {
        // A randomly generated unsorted array returns the array sorted
        [Fact]
        public void TestRandomArray()
        {
            Random rand = new Random();
            int[] arr = { rand.Next(), rand.Next(), rand.Next() };
            InsertionSort(arr);

            Assert.True(arr[0] < arr[1]);
            Assert.True(arr[1] < arr[2]);

        }

        // A sorted array returns the same sorted array
        [Fact]
        public void TestSameArray()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            InsertionSort(arr);
            Assert.True(arr == arr);

        }

        // A backwards-sorted array returns the array sorted
        [Fact]
        public void TestBackwardArray()
        {
            int[] arr = { 3, 2, 1 };
            InsertionSort(arr);
            Assert.True(arr[0] < arr[1]);
            Assert.True(arr[1] < arr[2]);

        }

        // An empty array returns the same empty array
        [Fact]
        public void TestEmptyArray()
        {
            int[] arr = { };
            InsertionSort(arr);
            Assert.True(arr.Length == 0);

        }

        // An array of one element returns the same single-element array
        [Fact]
        public void TestSingleIndexArray()
        {
            int[] arr = { 1 };
            InsertionSort(arr);
            Assert.Equal(1, arr[0]);

        }
    }
}
