using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    static class BinarySearch
    {
        static int[] array = { 12, 4, 17, 29, 30, 34, 2, 89, 12, 56, 84 };
        public static void Do()
        {
            int result;
            result = binarySearch(array, 0, array.Length - 1, 56);
            Console.WriteLine("Element at index "+result);
            result = binarySearch(array, 0, array.Length - 1, 84);
            Console.WriteLine("Element at index " + result);
        }

        public static int binarySearch(int[] array, int left, int right, int num)
        {
            if (right >= left)
            {
                //Step1: Find mid element
                int mid = (right + left) / 2;

                //Step2: Check if mid is the element/num
                if (array[mid] == num)
                {
                    return mid;
                }
                //Step3: Check if num is less than mid
                if (num < array[mid])
                {
                    return binarySearch(array, left, mid - 1, num);
                }
                else
                {
                    return binarySearch(array, mid+1, right, num);
                }
            }
            return -1;
        }
    }
}
