using System;

namespace Vsite.CSharp.Svojstva
{
    class Definicija
    {
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                this.Ime = ime;
                Prezime = prezime;
            }


            public string Prezime { get; protected set; }


            private string ime;
            public string Ime { 
                get { return ime; }
                set{
                    if(value == null)
                    {
                        throw new ArgumentNullException(nameof(value), $"Vrijednost {nameof(Ime)} ne smije biti null referenca");
                    }
                    if(value == string.Empty)
                    {
                        throw new ArgumentException($"Vrijednost {nameof(Ime)} ne smije biti prazan string", nameof(value));
                    }
                    ime = value;
                } 
            }


            private DateTime datumRodenja;
            public DateTime DatumRođenja {
                get => datumRodenja;
                set { 
                    datumRodenja = value.Date > DateTime.Now.Date ? 
                        throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(DatumRođenja)} mora biti manji od danasnjeg datuma.") : value;
                } 
            }

        }

        public class OsobaSPromjenivimPrezimenom : Osoba
        {
            public OsobaSPromjenivimPrezimenom(string ime, string prezime) : base(ime, prezime)
            { }

            // TODO:005 Napraviti potrebne promjene svojstva Prezime u baznoj klasi Osoba da se iz metode UdajSe može promijeniti prezime osobe.
            // TODO:006 Napisati unutar metode UdajSe kod kojim se mijenja prezime osobe.
            public void UdajSe(string prezimePartnera)
            {
                Prezime = prezimePartnera;
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("*** Osoba ***");

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            o1.DatumRođenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1.DatumRođenja.ToShortDateString());

            o1.Ime = "Pero";
            //o1.Prezime = "Kvrgić";
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");

            o1.DatumRođenja = new DateTime(2019, 4, 13);
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
            Console.ReadKey(true);
        }
    }
}
