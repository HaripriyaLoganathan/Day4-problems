using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;

namespace Demo35_ThreadRunLock_
{
    class MyClass
    {
         static Object olock = new Object();
        public static void Run()
        {
            lock(MyClass.olock)
            {
                for (int i = 1; i <= 5; i++)
                {

                    Console.WriteLine("It is a " + Thread.CurrentThread.Name);
                    Thread.Sleep(2000);
                }
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
            //lock(t1)
              //  t1.Abort();
            t2.Start();
           // lock(t2)
             //   t2.Abort();
            t3.Start();
           // lock(t3)
             //   t3.Abort();
            Console.Read();
        }
    }
}
