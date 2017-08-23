using System;

namespace String9
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, max = 0;
            char res=' ';
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();
            char[] c = s.ToCharArray();
            Array.Sort(c);
            for(int i=0;i<s.Length;i++)
            {
                count = 0;
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (c[i] == c[j])
                    {
                        count++;
                    }
                }
                if(max<count)
                {
                    max = count;
                    res = c[i];
                }
            }
            Console.WriteLine("Maximum occuring character is " + res);
            Console.Read();
        }
    }
}
