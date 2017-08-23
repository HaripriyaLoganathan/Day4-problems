using System;
using System.Linq;
namespace Linq5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            var v = from Character in s group Character by Character into result select result;
            foreach (var vin in v)
            {
                Console.WriteLine("Character " + vin.Key + ": " + vin.Count() + "times");
            }
            Console.Read();
        }
    }
}