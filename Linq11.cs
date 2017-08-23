using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            Console.WriteLine("Enter the number of elements in the list");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the elements of the list");
            for (int i = 0; i < n; i++)
            {
                l.Add(Convert.ToInt16(Console.ReadLine()));
            }
            Console.WriteLine("Enter the number of elements to display");
            int top = Convert.ToInt16(Console.ReadLine());
            l.Sort();
            l.Reverse();
            Console.WriteLine("The top {0} values of the list are..", top);
            foreach (var res in l.Take(top))
                Console.WriteLine(res);
            Console.Read();
        }
    }
}
