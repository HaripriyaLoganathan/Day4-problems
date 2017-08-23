using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticastEvent
{
    public delegate void Method(int a, int b);
    class Program
    {
        static void Addition(int a, int b)
        {
            Console.WriteLine("Addition of the numbers is " + (a + b));
        }
        static void Multiplication(int a, int b)
        {
            Console.WriteLine("Multiplication of the numbers is " + (a*b));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 2 numbers ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Method m = new Method(Addition);
            m += Multiplication;
            m(num1, num2);
            Console.Read();
        }       
    }
}
