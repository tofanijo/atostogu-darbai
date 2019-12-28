using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_2_uzduotis_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Paprašyti vartotojo įvesti darbuotojo ID, išdirbtas valandas ir valandinį įkainį
            //Išvesti darbuotojo ID, uždirbtą algą
            //Pvz.:
            //Įvesti ID : 01123
            //Įvesti val: 8
            //Įvesti €/ h: 100
            //Išvesti:
            // Darbuotojo ID  : 01123
            //Darbuotojo alga: 800

            string darbuotojoID;
            double dirbtosValandos;
            double EUuzVal;

            Console.WriteLine("Iveskite darbuotojo ID");
            darbuotojoID = (Console.ReadLine());
            Console.WriteLine("Iveskite dirbtas valandas");
            dirbtosValandos = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Iveskite valandini ikaini");
            EUuzVal = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Darbuotojo ID: {0}", darbuotojoID);
            Console.WriteLine("Uzdirbta alga: " + (dirbtosValandos * EUuzVal));
         
           
            Console.ReadLine();








        }
        }
    }
