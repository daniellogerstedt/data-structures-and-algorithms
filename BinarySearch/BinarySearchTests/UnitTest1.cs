using System;
using Xunit;
using BinarySearch;

namespace BinarySearchTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(15, new int[]{-10, -9, 0, 15, 22, 37}, 3)]
        [InlineData(1, new int[]{ -10, -9, 0, 15, 22, 37 }, -1)]
        [InlineData(7, new int[]{}, -1)]
        [InlineData(-99, new int[]{-100, -99, -98, -20, -10, -9, 0, 15, 22, 37, 44, 53, 60, 90, 99, 100 }, 1)]
        public void ArrayBinarySearchTestValidOutputForInputs(int key, int[] array, int expected)
        {
            int location = Program.BinarySearch(array, key);
            Assert.Equal(expected, location);
        }
    }
}
