using System;

namespace String14
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the input string to be searched ");
            string s = Console.ReadLine();
            string[] ss = { "hai", "hello", "welcome", "to", "biztalk360" };
            for (int i = 0; i < ss.Length; i++)
            {
                if (ss[i] == s)
                    flag = 1;

            }
            if (flag == 1)
                Console.WriteLine("string is present");
            else
                Console.WriteLine("String is not present");
            Console.Read();
        }
    }
}