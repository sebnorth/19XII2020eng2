using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how_many value: ");
            int how_many = int.Parse(Console.ReadLine());

            int counter = 0;

            int x = 13;

            while (counter < how_many)
            {
                if (x % 13 == 0 && x % 2 == 1)
                {

                    Console.Write("{0} ", x);
                    counter++;
                                }

                x += 13;
            }

            Console.ReadKey();
        }
    }
}
