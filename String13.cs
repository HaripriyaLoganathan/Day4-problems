using System;

namespace String13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Console.WriteLine("Enter the string1");
            string s1 = Console.ReadLine();
            Console.WriteLine("Enter the string2");
            string s2 = Console.ReadLine();
            a = s1.CompareTo(s2);
            if (a == 0)
            {
                Console.WriteLine("Both are equal");
            }
            else if (a < 0)
                Console.WriteLine("s1 is less than s2");
            else
                Console.WriteLine("s1 is greater than s2");
            Console.ReadLine();
        }
    }
}