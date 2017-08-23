using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Demo34_ThreadAdd_
{
    class MyClass
    {
        public static void Run()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("It is " + Thread.CurrentThread.Name);
                Thread.Sleep(2000);
            }
        }
    }
    class ThreadDemo
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(MyClass.Run);
            t1.Name = "First Child Thread";
            Thread t2 = new Thread(MyClass.Run);
            t2.Name = "Second Child Thread";
            Thread t3 = new Thread(MyClass.Run);
            t3.Name = "Third Child Thread";

            t1.Start();
            t2.Start();
            t3.Start();
            Console.Read();
        }
    }
}


