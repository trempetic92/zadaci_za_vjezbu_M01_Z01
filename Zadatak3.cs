using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak3
    {
        public static void zadatak3()
        {

            
            double a, b;
            Console.WriteLine("Produkt i kvocijent realnih decimalnih brojeva: \n");
            Console.WriteLine("Unesite prvi realni broj: ");
            while (!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Krivi unos, unesite realni broj.\n");
            }
            Console.WriteLine("Unesite drugi realni broj: ");
            while (!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Krivi unos, unesite realni broj.\n");
            }



            Console.WriteLine($"Produkt unesenih brojeva je: {a * b}");
            Console.WriteLine($"Kvocijent unesenih brojeva je: {a / b}\n");


        }
    }
}
