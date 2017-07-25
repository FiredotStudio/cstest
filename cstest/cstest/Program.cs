using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cstest
{
    class Program
    {
        static void Main()
        {
            int[] tab = new int[5];

            for(int i = 0; i<tab.Length;i++)
            {
                tab[i] = i + 1;
            }

            foreach(int element in tab)
            {
                Console.WriteLine(element);
            }

            Console.ReadKey();
        }
    }
}