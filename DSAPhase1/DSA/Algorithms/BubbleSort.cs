using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Algorithms
{
    class BubbleSort
    {
        static int[] array = { 43, 78, 21,3};
        
        public static void Do()
        {
            int n = array.Length;
            int counter = 1;
            Console.WriteLine("Before sorting ");
            for (int s = 0; s < array.Length; s++)
            {
                Console.Write(array[s]+",");
            }
            Console.WriteLine("\n After sorting ");
            //iteration loo
            for (int i = 0; i < n - 1; i++)
            {                
                for (int j = 0; j < n-i-1; j++)
                {
                    counter++;
                    if (array[j] > array[j + 1])
                    {
                        Console.WriteLine("array[j] " + array[j]);
                        Console.WriteLine("array[j+1] " + array[j+1]);                        
                        int temp = array[j];
                        Console.WriteLine("Temp = array[j] " + temp);
                        array[j] = array[j + 1];
                        Console.WriteLine("array[j] = array[j + 1]" + array[j]);
                        array[j + 1] = temp;
                        Console.WriteLine("array[j+1] = temp " + array[j + 1]);
                    }
                }
            }
            foreach (int num in array)
            {                
                Console.Write(num+",");
            }
            Console.WriteLine("\n No of iterations "+counter);
        }
    }
}
