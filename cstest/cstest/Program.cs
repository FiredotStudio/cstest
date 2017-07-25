using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cstest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[100];

            for(int i = 0; i < tab.Length; i++)
            {
                tab[i] = i + 1;
                Console.WriteLine("for: " + tab[i]);
            }

            foreach(int element in tab)
            {
                Console.WriteLine("foreach: " + element);
            }

            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Args[{0}]: {1}", i, args[i]);
            }

            Console.ReadKey();
        }
    }
}