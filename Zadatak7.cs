using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaci_za_vjezbu_M01_Z01
{
    internal class Zadatak7
    {
        public static void zadatak7()
        {
            /*
            7.	Napisati program u kojem ćete tražiti korisnika da unese rečenicu i spremiti unos u varijablu recenica. Tu rečenicu ćete zatim ispisati tako da ćete prvu trećinu ispisa velikim slovima, drugu trećinu malim slovima i treću trećinu opet velikim slovima. 
                Zatim ćete tražiti korisnika da unese jednu riječ te ćete ispisati poziciju te riječi u prethodnoj rečenici (znači rečenica bi trebala ostati nepromijenjena). Zatim ćete tražiti unos 5 suglasnika 
                s kojima ćete u početnoj rečenici zamijeniti samoglasnike (a, e, i , o, u - bez obzira na velika ili mala slova) svaki s jednim unesen suglasnikom (pomoću naredbe switch), a rezultat ćete spremiti u varijablu novaRecenica. 
                Na kraju ćete ispisati početnu rečenicu kako je unesena i početnu rečenicu s ponovljenom promjenom samoglasnika, ali bez varijable novaRecenica. 

                Napomene: 
                •	provjerite duljinu rečenice da ne bude manja od 3 znaka
                •	provjerite unos suglasnika
                •	varijable za suglasnike nazovite umjestoA, umjestoE, umjestoI, umjestoO, umjestoU
                •	pazite na velika i mala slova
                •	dodatno: ukoliko je na kraju rečenice dodano više praznina, maknite ih. 
                •	Npr: ako je unos "Ovo je rečenica.               " trebali biste uzeti samo "Ovo je rečenica."
                */

            Console.WriteLine("Unesite rečenicu sa minimalno 3 riječi...");
            string recenica = Console.ReadLine().TrimEnd();

            while (recenica.Length < 3)
            {
                Console.WriteLine("Niste unijeli rečenicu dulju od 3 znaka. Pokušajte ponovno:");
                recenica = Console.ReadLine().TrimEnd();
            }

            int trecina = recenica.Length / 3;
            string prviDio = recenica.Substring(0, trecina).ToUpper();
            string drugiDio = recenica.Substring(trecina, trecina).ToLower();
            string treciDio = recenica.Substring(trecina * 2).ToUpper();

            string promjenjenaRecenica = prviDio + drugiDio + treciDio;
            Console.WriteLine(promjenjenaRecenica);

            Console.WriteLine("Unesite riječ za pretragu u rečenici:");
            string rijec = Console.ReadLine();
            int index = recenica.IndexOf(rijec);

            if (index != -1)
            {
                Console.WriteLine($"Riječ '{rijec}' se nalazi na poziciji: {index}");
            }
            else
            {
                Console.WriteLine("Riječ nije pronađena.");
            }

            char[] suglasnici = new char[5];
            char[] samoglasnici = { 'a', 'A', 'e', 'E', 'i', 'I', 'o', 'O', 'u', 'U' };

            for (int i = 0; i < suglasnici.Length; i++)
            {
                Console.WriteLine($"Unesite {i + 1}. suglasnik:");

                while (true)
                {
                    string input = Console.ReadLine();
                    //Privjera da je stvarno 1 znak, da ne postoji u arrayu samoglasnici te da je unos slovo
                    if (input.Length == 1 && !samoglasnici.Contains(input[0]) && Char.IsLetter(input[0]))
                    {
                        suglasnici[i] = input[0];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Nije suglasnik, unesite ponovo:");
                    }
                }
            }
            string novaRecenica = "";
            foreach (char znak in recenica)
            {
                if (samoglasnici.Contains(znak))
                {
                    switch (char.ToLower(znak))
                    {
                        case 'a': novaRecenica += suglasnici[0]; break;
                        case 'e': novaRecenica += suglasnici[1]; break;
                        case 'i': novaRecenica += suglasnici[2]; break;
                        case 'o': novaRecenica += suglasnici[3]; break;
                        case 'u': novaRecenica += suglasnici[4]; break;
                    }
                }
                else
                {
                    novaRecenica += znak;
                }
            }

            //Moglo se i sa 1 for petljom ako bi uzeli u bzor da novaRecenica != novaRecenica[i]

            char[] slovkamo = new char[novaRecenica.Length];
            Console.WriteLine($"Originalna rečenica: {recenica}");
            for (int i = 0; i < novaRecenica.Length; i++)
            {
                slovkamo[i] = novaRecenica[i];
            }

            Console.Write($"Promjenjena rečenica: ");

            for (int i = 0; i < slovkamo.Length; i++)
            {
                Console.Write(slovkamo[i]);
            }
            Console.WriteLine();

        }


    }
}

