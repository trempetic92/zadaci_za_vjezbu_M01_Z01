using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak6
    {
        public static void zadatak6()
        {
            Console.WriteLine("Unesite godinu za provjeru jeli prijestupna...");
            int godina = Int32.Parse(Console.ReadLine());

            if (godina % 4 == 0 && (godina % 100 != 0 || godina % 400 == 0))
            {
                Console.WriteLine("Godina je prijestupna");
            }
            else
            {
                Console.WriteLine("Godina nije prijestupna");
            }
        }
    }
}
