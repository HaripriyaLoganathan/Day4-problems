using System;
namespace String1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter the String");
            string s = Console.ReadLine();
            char []c = s.ToCharArray();
            for(int i=0;i<c.Length;i++)
            {
                count++;
            }
            Console.WriteLine("Length ofthe string is " + count);
            Console.Read();

        }
    }
}
