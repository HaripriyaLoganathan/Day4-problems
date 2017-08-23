using System;

namespace Array1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements");
            for(int i=0;i< n;i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            Array.Sort(a);
            Console.WriteLine("After sorting array is");
            foreach (int arr in a)
                Console.WriteLine(arr);
            Console.ReadLine();
        }
    }
}
