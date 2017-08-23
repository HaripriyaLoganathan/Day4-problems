using System;

namespace String11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            Console.WriteLine("Enter the position and length of the substring");
            int po = Convert.ToInt16(Console.ReadLine());
            int len = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < c.Length; i++)
            {
                if (i >= po && i <= len + po - 1)
                {
                    Console.WriteLine(c[i]);
                }
            }
            Console.Read();
        }
    }
}