using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_2_uzduotis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string VARDAS = "";
            string PAVARDE = "";
            Console.WriteLine("Iveskite savo Varda:");
            VARDAS = Console.ReadLine();
            Console.WriteLine("Iveskite savo Pavarde:");
            PAVARDE = Console.ReadLine();

            Console.Write("Jusu Vardas Pavarde: {0}_{1}",  VARDAS, PAVARDE);
            Console.ReadLine();

        }
    }
}
