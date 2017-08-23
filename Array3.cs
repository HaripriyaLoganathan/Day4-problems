using System;

namespace Array3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine("Printing array in reverse order");
            for (int i = n-1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
            Console.ReadLine();
        }
    }
}
