using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_4_masyvai_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Padaryti tą patį kaip užduotyje 1 tik naudojant foreach ciklą

            char[] masyvas = new char[6];
            masyvas[0] = '1';
            masyvas[1] = '2';
            masyvas[2] = '3';
            masyvas[3] = '4';
            masyvas[4] = '5';
            
            foreach (var skaicius in masyvas)
            {
                Console.WriteLine(skaicius);
            }

            Console.ReadLine();




        }
    }
}
