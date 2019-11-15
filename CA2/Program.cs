using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nThis is CA2");
            //string s = Console.ReadLine();
            //Console.WriteLine(s);
            string arg = Console.ReadLine();
            while ( arg.Length != 0)
            {
                Console.WriteLine(arg);
                arg = Console.ReadLine();
            }
            

        }
    }
}
