using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo28_Genmethod__
{
    class Program
    {
        class GenClass<T>
        {
            public virtual T Add(T d1, T d2)
            {

                return d1;
            }

        }
        class GenInt : GenClass<int>
        {
            public override int Add(int a, int b)
            {
                return a + b;
            }
        }
        class GenString : GenClass<string>
        {
            public override string Add(string d1, string d2)
            {
                return d1 + d2;
            }
        }
        class Demo
        {
            static void Main(string[] args)
            {
                GenInt g = new GenInt();
                Console.WriteLine("Enter the 2 numbers");
                int a = Convert.ToInt16(Console.ReadLine());
                int b = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Addition of 2 numbers is {0}", g.Add(a, b));

                GenString gg = new GenString();
                Console.WriteLine("Enter the 2 Strings");
                string s1 = Console.ReadLine();
                string s2 = Console.ReadLine();
                Console.WriteLine("The string is " + gg.Add(s1, s2));

                Console.ReadLine();

            }
        }
    }
        
}