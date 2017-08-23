using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo33_Thread1_
{
    class Program
    {
        public static void TimeThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Time is {0}", DateTime.Now);
                Thread.Sleep(2000);

            }
        }
         static void Main(string[] args)
            {
                Thread t = new Thread(TimeThread);
                t.Start();
                Console.Read();

            }
        
    }
}

