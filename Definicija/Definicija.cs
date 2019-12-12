﻿using System;

namespace Vsite.CSharp.Svojstva
{
    class Definicija
    {
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                this.ime = ime;
                this.Prezime = prezime;
            }


            public string Prezime
            {
                get; protected set;
            }

            private string ime;
            public string Ime
            {
                get => ime;
                set
                {
                   // ime = (value ?? throw new ArgumentNullException($"{nameof(value)}no null")).Length > 0 ? value : throw new ArgumentException($"{nameof(value)}no empty");
                    if (value == null)
                        throw new ArgumentNullException($"{nameof(value)}no null");
                    if (value.Length == 0) 
                        throw new ArgumentException($"{nameof(value)}no empty");
                    ime = value;
                }
            }



            private DateTime datumRođenja;

            public DateTime DatumRođenja
            {
                get => datumRođenja;
                set
                {
                    if (value.Date > DateTime.Now.Date)
                        throw new ArgumentOutOfRangeException($"{nameof(value)} must not be");
                    datumRođenja = value;
                }
            }

        }

        // TODO:004 Definirati da je klasa OsobaSPromjenivimPrezimenom izvedena iz klase Osoba, ukloniti polja Ime i Prezime iz klase OsobaSPromjenivimPrezimenom 
        // te iz konstruktora inicijalizirati članove bazne klase.
        public class OsobaSPromjenivimPrezimenom : Osoba
        {

            public OsobaSPromjenivimPrezimenom(string ime, string prezime) : base(ime,prezime)
            { }

            // TODO:005 Napraviti potrebne promjene svojstva Prezime u baznoj klasi Osoba da se iz metode UdajSe može promijeniti prezime osobe.
            public void UdajSe(string prezimePartnera)
            {
                Prezime = prezimePartnera;
            }
        }


        static void Main(string[] args)
        {
            // TODO:003 Provjeriti donjim kodom ispravnost promjena (zakomentirati naredbe koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba).

            Console.WriteLine("*** Osoba ***");

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            o1.DatumRođenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1.DatumRođenja.ToShortDateString());

            o1.Ime = "Pero";
            //o1.Prezime = "Kvrgić";
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            try
            {
                o1.DatumRođenja = new DateTime(2025, 4, 13);
                Console.WriteLine(o1.DatumRođenja.ToShortDateString());
            }
            catch (ArgumentOutOfRangeException e) {
                Console.WriteLine("Ne valja datum");
            }
           

            // TODO:006 Pokrenuti program i provjeriti ispis za OsobuSPromjenivimPrezimenom.
            // TODO:007 Pokrenuti testove (5 testova u grupi "TestDefinicijeSvojstva" mora proći).
            Console.WriteLine();
            Console.WriteLine($"*** OsobaSPromjenivimPrezimenom ***");

            OsobaSPromjenivimPrezimenom o2 = new OsobaSPromjenivimPrezimenom("Nives", "Celzius");
            Console.WriteLine($"Prije udaje: {o2.Ime} {o2.Prezime}");
            o2.UdajSe("Fahrenheit");
            Console.WriteLine($"Nakon udaje: {o2.Ime} {o2.Prezime}");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
