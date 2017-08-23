using System;
namespace String2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            Array.Reverse(c);
            Console.WriteLine("After splitting string in reverse order is");
            foreach (char co in c)
                Console.WriteLine(co);
            Console.Read();
        }
    }
}
