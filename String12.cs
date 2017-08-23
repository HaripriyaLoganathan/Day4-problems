using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the substring");
            string sub = Console.ReadLine();
            if (s.Contains(sub))
            {
                Console.WriteLine("Substring is present in the string");
            }
            else
                Console.WriteLine("Substring is not present");
            Console.ReadLine();
        }
    }
}