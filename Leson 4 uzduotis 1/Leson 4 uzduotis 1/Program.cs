using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_4_uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Isvesti savo varda 10 kart naudojant for cikla.

            string vardas = "Romanas   ";
            for (int i = 0; i < vardas.Length;i++)
                Console.WriteLine("Romanas {0}", i);
            Console.ReadLine();

        }
    }
}
