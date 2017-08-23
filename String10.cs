
using System;

namespace String10
{
    class Program
    {
        static void Main(string[] args)
        {
            char temp = '\0';
            Console.WriteLine("Enter the input String");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (c[j].CompareTo(c[j + 1]) > 0)
                    {
                        temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.Read();
        }
    }
}