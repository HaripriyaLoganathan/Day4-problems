using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            Console.WriteLine("string reverse is  ");
            for(int i=c.Length-1;i>=0; i--)
            {
                Console.Write(c[i]);
            }
            Console.Read();
        }
    }
}
