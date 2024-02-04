using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak2
    {
        public static void zadatak2()
        {
            int a, b;
            Console.WriteLine("Zbroj i razlika cijelih brojeva: \n");
            Console.WriteLine("Unesite prvi cijeli broj: ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Krivi unos, unesite cijeli broj.\n");
            }
            Console.WriteLine("Unesite drugi cijeli broj: ");
            while (!int.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Krivi unos, unesite cijeli broj.\n");
            }



            Console.WriteLine($"Zbroj unesenih brojeva je: {a + b}");
            Console.WriteLine($"Razlika unesenih brojeva je: {a - b}");


        }
    }
}
