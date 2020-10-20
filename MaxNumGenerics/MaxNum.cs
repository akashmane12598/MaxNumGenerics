using System;
using System.Collections.Generic;
using System.Text;

namespace MaxNumGenerics
{
    public class MaxNum<T> where T:IComparable
    {
        public static T Max(T[] arr)
        {
            Array.Sort(arr);
            return arr[^1];
        }

    }
}
