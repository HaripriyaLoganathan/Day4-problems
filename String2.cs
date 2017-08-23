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
            Console.WriteLine("String is splitted into characters");
            foreach (char co in c)
                Console.WriteLine(co);
            Console.Read();
        }
    }
}
