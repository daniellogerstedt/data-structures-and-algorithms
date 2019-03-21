using System;

namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int BinarySearch(int[] array, int key)
        {
            if (array.Length == 0) return -1;
            int start = 0;
            int end = array.Length - 1;
            int mid = (int)Math.Ceiling(Decimal.Divide(end, 2));
            while (end > start)
            {
                if (array[mid] == key) return mid;
                if (key > array[mid])
                {
                    start = mid + 1;
                }
                else if (key < array[mid])
                {
                    end = mid - 1;
                }
                mid = start + (int)Math.Ceiling(Decimal.Divide(end - start, 2));
            }
            if (array[mid] == key) return mid;
            return -1;
        }
    }
}
