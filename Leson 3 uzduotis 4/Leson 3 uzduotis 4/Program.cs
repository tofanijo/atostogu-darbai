using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_3_uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Išvesti skaičius nuo 0 iki 100, kurie dalinasi iš 3 be liekanos.



            for (int i = 0; i <= 100; i++)
            {

                if ((i % 3) == 0)

                    Console.Write(i);

                Console.ReadLine();
            }
            
        }
    }
}