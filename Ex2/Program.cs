using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter b: ");
            int b = int.Parse(Console.ReadLine());

            if (a < b) Console.WriteLine(a);

            if (b < a) Console.WriteLine(b);

            if (a == b) Console.WriteLine("Both numbers are equal");

            Console.ReadKey();
        }
    }
}
