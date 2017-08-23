using System;

namespace Array4
{
    class Program
    {
        static void SortArray(int []a,int n)
        {
            for(int i=0;i<n-1;i++)
            {
                for(int j=i+1;j< n;j++)
                {
                    if(a[i]<a[j])
                    {
                        a[i] = a[i] + a[j];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j];
                    }
                }
            }
            Console.WriteLine("Array in decending order");
            foreach (int res in a)
                Console.WriteLine(res);
        }
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

            SortArray(a, n);
            Console.ReadLine();
        }
    }
}
