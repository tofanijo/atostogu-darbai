using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_4_uzduotis_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Parodyti daugybos lentelę visų skaičių nuo 1 iki 10 atskirose eilutėse
            //a. 1x1 = 1, 1x2 = 3, 1x3 = 3...
            //b. 2x1 = 1, 2x2 = 3, 3x3 = 3...=
            //c. 10x1 = 1, 10x2 = 3, 10x3 = 3...
            //d.P.S.naudoti ciklą cikle

            for (int i = 0; i <= 10; i++)
            {
                for (int k = 1; k <= 10; k++)
                {
                    Console.Write($"{i}x{k}={i * k}, ");

                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
