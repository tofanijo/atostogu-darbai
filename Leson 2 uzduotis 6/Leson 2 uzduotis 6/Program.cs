using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_2_uzduotis_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sukeisti A ir B kintamųjų reikšmes nenaudojant trečiojo tarpinio kintamojo

            int A = 8;
            int B = 15;

            A = A * B;
            B = A / B;
            A = A / B;


            //Console.WriteLine("After swaping:" + "A = " + A + ", B = " + B);

            Console.WriteLine("A = {0}", A);
            Console.WriteLine("B = {0}", B);
            Console.ReadLine();
        }
    }
}
