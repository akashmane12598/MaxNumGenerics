using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumGenerics
{
    public class MaxNum<T> where T:IComparable
    {
        public static T max;

        public static void Max(T[] arr)
        {
            Array.Sort(arr);
             max=arr[^1];
            PrintMax(max);
        }
        public static void PrintMax(T max)
        {
            Console.WriteLine("Maximum Value for "+typeof(T)+" is: " + max);
        }

    }
}
