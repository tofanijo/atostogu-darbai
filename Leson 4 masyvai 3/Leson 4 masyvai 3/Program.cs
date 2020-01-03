using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_4_masyvai_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Išvesti masyvo iš 1 - os užduoties elementų sumą

            int[] masyvas1 = { 1, 2, 3, 4, 5 };
            int suma = 0;

            for (int i = 0; i < 5; i++)
            {
                suma += masyvas1[i];
            }
                

                    Console.WriteLine(suma);
                
                Console.ReadLine();
            }
        }
    }

