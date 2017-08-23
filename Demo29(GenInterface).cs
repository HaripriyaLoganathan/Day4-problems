using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo29_GenInterface_
{
    interface GenInterface<T>
    {
        T Add(T arg1, T arg2);
        T Subtract(T arg1, T arg2);
        T Multiply(T arg1, T arg2);
        T Divide(T arg1, T arg2);
    }
    class BasicMath : GenInterface<int>
    {
        public int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
        public int Subtract(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public int Multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }
        public int Divide(int arg1, int arg2)
        {
            return arg1 / arg2;
        }

       

        class Program
    {
        static void Main(string[] args)
        {
                BasicMath bo = new BasicMath();
                
                    Console.WriteLine("Enter the numbers to add");
                    int num1 = Convert.ToInt16(Console.ReadLine());
                    int num2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("The result of addition is " + bo.Add(num1, num2));

                    Console.WriteLine("Enter the numbers to subtract");
                    int a = Convert.ToInt16(Console.ReadLine());
                    int b = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("The result of subtraction is " + bo.Subtract(a, b));
          
                    Console.WriteLine("Enter the numbers to multiply ");
                    int a1 = Convert.ToInt16(Console.ReadLine());
                    int a2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("The result of multiplication is " + bo.Multiply(a1, a2));

                    Console.WriteLine("Enter the numbers to divide ");
                    int n1 = Convert.ToInt16(Console.ReadLine());
                    int n2 = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine("The result of division is " +bo.Divide(n1, n2));
                Console.Read();
                }
            }
    }
}
