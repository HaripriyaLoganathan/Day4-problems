using System;
using System.Linq;
namespace Linq1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the numbers");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            var v = from i in arr where i % 2 == 0 select i;
            Console.WriteLine("The even number values are..");
            foreach (var res in v)
                Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}