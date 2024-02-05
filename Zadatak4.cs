using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak4
    {
        public static void zadatak4()
        {
            int a = 0, b = 0;
            int slucajniBroj = new Random().Next(1, 501);
            bool nastaviZaPrvi = false;


            Console.WriteLine("Unesite brojeve raspona za provjeru između 1-500...\n");


            while (!nastaviZaPrvi)
            {
                Console.WriteLine("Unesite prvi broj raspona: \n");

                //Ukoliko se može parsati da true i vrijednost spremi u varijablu. Dokle god je false, tražit će ponovni unos
                while (!Int32.TryParse(Console.ReadLine(), out a))
                {
                    if (a < 1 && a > 500)
                    {
                        Console.WriteLine("Niste unijeli cijeli broj koji je u rasponu od 1-500, unesite ponovo...\n");
                    }
                }

                Console.WriteLine($"Koristi uneseni broj {a}? (y/n)");
                char yesNo = char.Parse(Console.ReadLine().ToLower());

                switch (yesNo)
                {
                    case 'y':
                        Console.WriteLine($"Prvi broj za raspon je {a}");
                        //Završava petlju te se kod nastavlja dalje
                        nastaviZaPrvi = true;
                        break;
                    case 'n':
                        //Vraća na početak petlje
                        Console.WriteLine("Možete ponovo unijeti prvi broj...\n");
                        break;
                    default:
                        //Vraća na početak unosa za switch
                        Console.WriteLine("Unesite \"y\" za da \"n\" za ne...");
                        break;
                }
            }

            bool nastaviZaDrugi = false;

            while (!nastaviZaDrugi)
            {
                Console.WriteLine("Unesite drugi broj raspona: ");
                while (!Int32.TryParse(Console.ReadLine(), out b))
                {
                    if (b < 1 && b > 500)
                    {
                        Console.WriteLine("Niste unijeli cijeli broj koji je u rasponu od 1-500, unesite ponovo...\n");
                    }
                }
                Console.WriteLine($"Koristi uneseni broj {b}? (y/n)");
                char yesNo = char.Parse(Console.ReadLine().ToLower());
                switch (yesNo)
                {
                    case 'y':
                        Console.WriteLine($"Drugi broj za raspon je {b}");
                        nastaviZaDrugi = true;
                        break;
                    case 'n':
                        Console.WriteLine("Možete ponovo unijeti drugi broj...\n");
                        break;
                    default:
                        Console.WriteLine("Unesite \"y\" za da \"n\" za ne...");
                        break;
                }
            }


            if (a < b)
            {
                (a, b) = (b, a);
                if (slucajniBroj >= a && slucajniBroj <= b)
                {
                    Console.WriteLine($"Slučajni broj {slucajniBroj} je u rasponu");
                }
                else
                {
                    Console.WriteLine($"Slućajni broj {slucajniBroj} nije u rasponu");
                }
            }
        }
    }
}
