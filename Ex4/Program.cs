using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            int digit, product = 1;


            for ( ; x > 0 ; )
            {
                // extract digit
                digit = x % 10;

                // update the product 
                product *= digit;

                // update x 
                x /= 10; 
            }

            Console.WriteLine("Product of digits: {0}", product);

            Console.ReadKey();
        }
    }
}
