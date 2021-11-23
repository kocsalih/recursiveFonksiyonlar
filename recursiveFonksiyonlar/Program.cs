using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursiveFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 15; i++)
            {
                long sayiFaktoriyel = faktoriyel(i);
                Console.WriteLine($"{i} sayısının faktoriyeli "+sayiFaktoriyel);
            }

            Console.ReadLine();
        }

        static long faktoriyel(long sayac)
        {

            if (sayac<=1)
            {
                return 1;
            }
            return sayac * faktoriyel(sayac - 1);
        }
    }
}
