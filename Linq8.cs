using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };
            Console.WriteLine("Enter the starting letter of the string");
            string start = Console.ReadLine();
            Console.WriteLine("Enter the ending letter of the string");
            string end = Console.ReadLine();
            var v = from word in s where word.StartsWith(start) where word.EndsWith(end) select word;
            foreach (var res in v)
                Console.WriteLine("The city is " + res);
            Console.Read();
        }
    }
}
