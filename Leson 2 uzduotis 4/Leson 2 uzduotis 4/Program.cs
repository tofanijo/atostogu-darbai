using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_2_uzduotis_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paprašyti vartotojo įvesti skaičių(sekundes)
            //Išvesti: kiek tai valandų, minučių, sekundžių


            double sekundes;

            Console.WriteLine("Iveskite sekundziu skaiciu");
            sekundes = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Valandu bus:" + (sekundes / 3600));
            Console.WriteLine("Minuciu bus:" + (sekundes / 60));
            Console.WriteLine("Sekundziu bus: {0}", sekundes);

            Console.ReadLine();

        }
    }
}
