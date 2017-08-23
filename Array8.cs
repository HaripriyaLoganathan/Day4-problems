using System;
namespace Array8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] a = new int[n, n];

            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                        sum = sum + a[i, j]; 
                }
            }
             Console.WriteLine("Sum of the diagonal elements is {0}",sum);

            Console.ReadLine();
        }
    }
}
