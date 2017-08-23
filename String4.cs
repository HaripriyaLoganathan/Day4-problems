using System;
namespace String4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            string[] c = s.Split();
            Console.WriteLine("After splitting string in reverse order is");
                Console.WriteLine(c.Length);
            Console.Read();
        }
    }
}
