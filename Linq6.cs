using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] week = {"Sunday", "Monday", "Tuesday","Wednesday","Thursday", "Friday", "Saturday" };
            var v = from days in week select days;
            Console.WriteLine("Days of the week are...");
            foreach (var res in v)
                Console.WriteLine(res);
            Console.Read();
        }
    }
}
