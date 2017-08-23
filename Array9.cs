using System;

namespace Array9
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt16(Console.ReadLine());
            }
            for(int i=0;i< n;i++)
            {
                b[i] = a[i];
            }
            Console.WriteLine("After coping the elements... ");
            foreach (int i in b)
                Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
