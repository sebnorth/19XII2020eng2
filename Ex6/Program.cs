using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n - number of elements of the array tab: ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = int.Parse(Console.ReadLine());
            }

            foreach (int item in tab)
            {
                Console.Write("{0} ", item);
            }

            int counter = 0;

            Console.WriteLine("Negative values: ");
            foreach (int item in tab)
            {
                if (item<0)
                {
                    Console.Write("{0} ", item);
                    counter++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Number of negative values is: {0}", counter);

            Console.ReadKey();
        }
    }
}
