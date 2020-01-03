using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_4_masyvai_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukurti masyvą iš 5 int elementų ir išvesti jį naudojant for ciklą
            int[] masyvas1 = {1,2,3,4,5};
            

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(masyvas1[i]);
            }
            Console.ReadLine();
        }
    }
}
