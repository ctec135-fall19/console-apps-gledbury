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
            string arg = Console.ReadLine();
            while ( arg != null)
            {
                Console.WriteLine(arg);
                arg = Console.ReadLine();

            }
            Console.WriteLine("There are no more arguments from CA1.");
        }
    }
}
