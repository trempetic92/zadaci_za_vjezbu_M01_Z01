using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak5
    {
        public static void zadatak5()
        {
            int a;

            Console.WriteLine("Unesite broj za provjeru jeli dijeljiv sa 3 ili 5...");

            a = Int32.Parse(Console.ReadLine());

            if (a % 3 == 0 || a % 5 == 0) 
            {
                Console.WriteLine("Broj je dobar");
            }
            else
            {
                Console.WriteLine("Broj nije dobar");
            }

        }
    }
}
