using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String8
{
    class Program
    {
        static void Main(string[] args)
        {
            int vowels = 0, consonants = 0;
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            for (int i = 0; i < s.Length; i++)
            {
                if (c[i] == 'a' || c[i] == 'e' || c[i] == 'i' || c[i] == 'o' || c[i] == 'u' || c[i] == 'A' || c[i] == 'E' || c[i] == 'I' || c[i] == 'O' || c[i] == 'U')
                {
                    vowels++;
                }
                else
                    consonants++;
            }
            Console.WriteLine("Vowels ={0}\nConsonants ={1}", vowels, consonants);
            Console.Read();
        }
    }
}
