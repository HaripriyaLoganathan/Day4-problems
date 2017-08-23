using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq9
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            l.Add(10);
            l.Add(110);
            l.Add(90);
            l.Add(78);
            l.Add(987);
            l.Add(345);
            l.Add(91);

            List<int> v = l.FindAll(num => num > 80 ?true:false);
            foreach (var res in v)
                Console.WriteLine(res);
            Console.Read();
        }
    }
}
