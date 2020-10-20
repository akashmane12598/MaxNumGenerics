using System;

namespace MaxNumGenerics
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Code!");
            Console.WriteLine();
            int[] arr1 = { 10, 20, 30, 40, 50 };
            MaxNum<int>.Max(arr1);
            

            Console.WriteLine();
            double[] arr2 = { 10.5, 20.5, 30.5, 40.5, 50.5 };
            MaxNum<double>.Max(arr2);

            Console.WriteLine();
            string[] arr3 = { "Rohit","Virat","Rahul","Shami","Bumrah" };
            MaxNum<string>.Max(arr3);

        }
    }
}
