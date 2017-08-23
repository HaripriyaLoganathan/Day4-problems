using System;
public delegate string StrMyDel(string s);
namespace Delegates
{
    class TestDelegate
    {
        public string Space(string str)
        {
            string str1 = "";
            char[] c = str.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                str1 += c[i];
                str1 += " ";
            }
            return str1;
        }
        public string Reverse(string str)
        {
            string str2 = "";
            char[] c = str.ToCharArray();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += c[i];
            }
            return str2;
        }

    }

    class DemoDell : TestDelegate
    {
        static void Main(string[] args)
        {
            DemoDell dd = new DemoDell();
            StrMyDel s1 = new StrMyDel(dd.Space);
            StrMyDel s2 = new StrMyDel(dd.Reverse);
            Console.WriteLine("Enter the string to insert spaces");
            string str1 =Console.ReadLine();
            Console.WriteLine("String with space is " + s1(str1));
            Console.WriteLine("Enter the string to reverse");
            string str2 = Console.ReadLine();
            Console.WriteLine("Reverse of the string is " + s2(str2));
            Console.Read();
        }
    }
}