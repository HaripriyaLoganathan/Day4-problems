using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            Console.WriteLine("Enter the number of elements in the list");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the elements of the list");
            for(int i=0;i< n;i++)
            {
                l.Add(Convert.ToInt16(Console.ReadLine()));
            }
            Console.WriteLine("Enter the value above you want to display");
            int value = Convert.ToInt16(Console.ReadLine());
            List<int> v = l.FindAll(num => num > value ? true : false);
            Console.WriteLine("The numbers above the value are...");
            foreach (var res in v)
                Console.WriteLine(res);
            Console.Read();
        }
    }
}
