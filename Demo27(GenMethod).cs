using System;
namespace Demo27_Genmethod_
{
    class GenDemo<T>
    {
        public string GenMethod(T data)
        {
            string s = data.ToString();
            return s;
        }

    }
    class Demo
    {
        static void Main(string[] args)
        {
            GenDemo<int> g = new GenDemo<int>();
            Console.WriteLine("Enter the integer input ");
            int a = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("String value for {0} is {1}", a, g.GenMethod(a));

            GenDemo<double> g1 = new GenDemo<double>();
            Console.WriteLine("Enter the double input");
            double d = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("String value for {0} is {1}", d, g1.GenMethod(d));
            Console.ReadLine();
        }
    }
}
