using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leson_2_uzduotis_7
{
    class GFG
    {
        
        
            //Paprašyti vartotojo įvesti 2 ženklų skaičių. Išvesti skaitmenų sumą.Pvz.: skaičius 12, rezultatas 1 + 2 = 3
            //Pastaba: nenaudoti ciklų, galima panaudoti dalybą "/" be kablelio, paskui matematinį mod "%".


            static int getSum(int n)

            {

                int sum = 0;



                while (n != 0)

                {

                    sum = sum + n % 10;

                    n = n / 10;

                }



                return sum;

        }




        static void Main(string[] args)

        {
            Console.WriteLine("Iveskite dvizenkli skaiciu");
            int n = 0;
            //if (!int.TryParse(Console.ReadLine(), out n))
                //int n = 12;

                Console.Write(getSum(n));
            Console.ReadLine();

            }

        }


    }
    
