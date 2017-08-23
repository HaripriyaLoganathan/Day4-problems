using System;
using System.Linq;
namespace Linq12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            var v = s.Split(' ').Where(word => String.Equals(word, word.ToUpper()));
            Console.WriteLine("The uppercase string is");
            foreach (var res in v)
                Console.WriteLine(res);
            Console.Read();
        }
    }
}