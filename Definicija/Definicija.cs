﻿namespace Vsite.CSharp.Svojstva
{
    class Definicija
    {
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                Ime = ime;
                Prezime = prezime;
            }

            // TODO:000 Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase.

            public string? Prezime;


            // TODO:001 Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
            // zadavanje nul-referencom ili praznim znakovnim nizom. U tim slučajevima treba baciti iznimke tipa ArgumentNullException, odnosno ArgumentException.

            public string? Ime;


            // TODO:002 Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
            // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odgovarajući kod za hvatanje
            // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.

            public DateTime DatumRođenja;

        }

        // TODO:004 Definirati da je klasa OsobaSPromjenivimPrezimenom izvedena iz klase Osoba, ukloniti polja Ime i Prezime iz klase OsobaSPromjenivimPrezimenom 
        // te iz konstruktora inicijalizirati članove bazne klase.
        public class OsobaSPromjenivimPrezimenom
        {
            public string? Ime;
            public string? Prezime;

            public OsobaSPromjenivimPrezimenom(string ime, string prezime)
            { 
            }

            // TODO:005 Napraviti potrebne promjene svojstva Prezime u baznoj klasi Osoba da se iz metode UdajSe može promijeniti prezime osobe.
            // TODO:006 Napisati unutar metode UdajSe kod kojim se mijenja prezime osobe.
            public void UdajSe(string prezimePartnera)
            {
            }
        }


        static void Main()
        {
            // TODO:003 Provjeriti donjim kodom ispravnost promjena (zakomentirati naredbe koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba).

            Console.WriteLine("*** Osoba ***");

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            o1.DatumRođenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1.DatumRođenja.ToShortDateString());

            o1.Ime = "Pero";
            o1.Prezime = "Kvrgić";
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            o1.DatumRođenja = new DateTime(2025, 4, 13);
            Console.WriteLine(o1.DatumRođenja.ToShortDateString());

            // TODO:007 Pokrenuti program i provjeriti ispis za OsobuSPromjenivimPrezimenom.
            // TODO:008 Pokrenuti testove (5 testova u grupi "TestDefinicijeSvojstva" mora proći).
            Console.WriteLine();
            Console.WriteLine($"*** OsobaSPromjenivimPrezimenom ***");

            OsobaSPromjenivimPrezimenom o2 = new OsobaSPromjenivimPrezimenom("Nives", "Celzius");
            Console.WriteLine($"Prije udaje: {o2.Ime} {o2.Prezime}");
            o2.UdajSe("Fahrenheit");
            Console.WriteLine($"Nakon udaje: {o2.Ime} {o2.Prezime}");

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
