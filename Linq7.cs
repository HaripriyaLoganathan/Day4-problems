using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements in the array");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            var v = from Number in arr group Number by Number into result select result;
            foreach (var vin in v)
            {
                Console.WriteLine("Number " + vin.Key + "   Number*Frequency " + vin.Sum() + "   Frequency" + vin.Count());
            }
            Console.Read();
        }
    }
}
