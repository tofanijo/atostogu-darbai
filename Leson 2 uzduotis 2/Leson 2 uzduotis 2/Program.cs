using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_2_uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Paprašyti vartotojo įvesti apskritimo spindulį. 
            //Išvesti apskritimo ilgį ir plotą.
            //Pastaba: naudoti "pi" skaičiui naudoti Math.PI

            Console.WriteLine("Iveskite apskritimo spinduli:");
            double apskritimoDiametras = Convert.ToDouble(Console.ReadLine());
            double apskritimoSpindulys = apskritimoDiametras / 2;
            

            double apskritimoIlgis = 2 * Math.PI * (apskritimoSpindulys);
            Console.WriteLine("Apskritimo ilgis: {0}", apskritimoIlgis);
            double apskritimoPlotas = Math.PI * Math.Sqrt(apskritimoSpindulys);
            Console.WriteLine("Apskritimo plotas: {0}", apskritimoPlotas);
            Console.ReadLine();


        }
    }
}
