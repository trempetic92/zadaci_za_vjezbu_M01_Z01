1.	Napisati program koji će ispisati temperature ledišta i vrelišta vode, u dva reda.
2.	Napisati program koji učitava dva cijela broja i ispisuje zbroj i razliku.
3.	Napisati program koji učitava dva realna (decimalna) broja i ispisuje njihov produkt i kvocijent.
4.	Napišite program koji traži korisnika unos dva cijela broja u rasponu od 1 do 500 koji će predstavljati određeni raspon brojeva za provjeru (npr. 123 i 345). Za svaki broj ćete pitati hoće li ta granica raspona biti uključena u provjeru ili ne. Kreirat ćete slučajni broj koristeći int slucajniBroj = new Random().Next(1, 501); te provjeriti je li taj slučajni broj u rasponu definiranom prethodno unesenim brojevima (pazite na granice raspona). Npr: za 123 i 345, ako je slucajniBroj = 200 onda je u rasponu, a ako je slucajniBroj = 400 onda nije. Ako je slucajniBroj = 123 ovisi o definiciji granica raspona.
5.	Napišite program koji traži unos broja i ispisuje je li taj broj djeljiv s 5 ili 3. Ako jest, ispisati "Broj je dobar.", inače ispisati "Broj nije dobar.". (Koristiti operator modulo (%) koji daje ostatak cjelobrojnog dijeljenja, npr. 7 % 5 = 2)
6.	Napišite program koji traži unos godine i ispisuje je li ta godina prijestupna ili nije. Godina je prijestupna ako je djeljiva s 4 i nije djeljiva sa 100 osim ako je djeljiva s 400.
7.	Napisati program u kojem ćete tražiti korisnika da unese rečenicu i spremiti unos u varijablu recenica. Tu rečenicu ćete zatim ispisati tako da ćete prvu trećinu ispisa velikim slovima, drugu trećinu malim slovima i treću trećinu opet velikim slovima. Zatim ćete tražiti korisnika da unese jednu riječ te ćete ispisati poziciju te riječi u prethodnoj rečenici (znači rečenica bi trebala ostati nepromijenjena). Zatim ćete tražiti unos 5 suglasnika s kojima ćete u početnoj rečenici zamijeniti samoglasnike (a, e, i , o, u - bez obzira na velika ili mala slova) svaki s jednim unesen suglasnikom (pomoću naredbe switch), a rezultat ćete spremiti u varijablu novaRecenica. Na kraju ćete ispisati početnu rečenicu kako je unesena i početnu rečenicu s ponovljenom promjenom samoglasnika, ali bez varijable novaRecenica. 
Napomene: 
•	provjerite duljinu rečenice da ne bude manja od 3 znaka
•	provjerite unos suglasnika
•	varijable za suglasnike nazovite umjestoA, umjestoE, umjestoI, umjestoO, umjestoU
•	pazite na velika i mala slova
•	dodatno: ukoliko je na kraju rečenice dodano više praznina, maknite ih. 
•	Npr: ako je unos "Ovo je rečenica.               " trebali biste uzeti samo "Ovo je rečenica."
