using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array");
            int n = Convert.ToInt16(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements in the array");
            for(int i=0;i< n;i++)
            {
                arr[i] = Convert.ToInt16(Console.ReadLine());
            }
            var v = from Number in arr let SqrNo = Number * Number select new { Number, SqrNo };
            foreach(var vin in v)
            {
                Console.WriteLine(vin);
            }
            Console.Read();
        }
    }
}
