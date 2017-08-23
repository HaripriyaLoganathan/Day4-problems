using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 strings");
            string s1 = Console.ReadLine();
            char[] c1 = s1.ToCharArray();
            string s2 = Console.ReadLine();
            char []c2 = s2.ToCharArray();
            int count = 0;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if (c1[i] == c2[i])
                        count++;
                }
                if (count == s1.Length)
                    Console.WriteLine("Both are equal");
                else
                    Console.WriteLine("They are not equal");
            }
            else
                Console.WriteLine("They are not equal");
            Console.Read();
        }
    }
}
