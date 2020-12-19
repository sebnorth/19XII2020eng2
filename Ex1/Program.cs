using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number n: ");
            int n = int.Parse(Console.ReadLine());

            double result = (n + n*n) / 3.0;

            Console.WriteLine("Result is {0}: ", result);

            Console.ReadKey();
        }
    }
}
