using System;

namespace Array2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[,] a = new int[n,n];
            
            Console.WriteLine("Enter the array elements");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            int[,] b = a.Clone() as int[,];
            //Array.Copy(a, b,n);
            Console.WriteLine("After coping array is ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            // foreach (int i in b)
            //   Console.WriteLine(i);

            Console.ReadLine();
        }
    }
}
