using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String6
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = 0, alpha = 0, symbol = 0;
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray(); 
            for(int i=0;i<c.Length;i++)
            {
                if (c[i] >= 48 && c[i] <= 57)
                {
                    digit++;
                }
                else if (c[i] >= 65 && c[i] <= 90 || c[i] >= 97 && c[i] <= 122)
                {
                    alpha++;
                }
                else
                    symbol++;
            }
            Console.WriteLine(" Alphabets={0}\n Digits={1}\n Symbols={2}", alpha, digit, symbol);
            Console.Read();
        }
    }
}
