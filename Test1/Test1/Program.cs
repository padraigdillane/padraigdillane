using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static String location;
        static DateTime time;

        static void Main(string[] args)
        {
            Console.WriteLine(location ==null ? "location is null" : location);
            
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            Console.ReadLine();
        }
    }
}
