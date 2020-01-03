using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Leson_4_uzduotis_4
{
    class Program
    {
        static void Main(string[] args)

        {
            string[] trikampis =
            {


                "*",
                "**",
                "***",
                "****",
               
            };

            for (int i = 0; i < trikampis.Length; i++)
            {
                Console.WriteLine(trikampis[i]);

            }
            Console.ReadLine();
        }
    }

}