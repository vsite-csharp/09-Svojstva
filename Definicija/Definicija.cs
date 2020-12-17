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

            // Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase.

            public string Prezime { get; protected set; }


            // Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
            // zadavanje nul-referencom ili praznim znakovnim nizom. U tim slučajevima treba baciti iznimke tipa ArgumentNullException, odnosno ArgumentException.
            private string ime;

            public string Ime {
                get { return ime; }
                set {
                    if (value == null)
                        throw new ArgumentNullException(nameof(value), $"Vrijednost {nameof(Ime)} ne smije biti nul referenca");
                    if (value == string.Empty)
                        throw new ArgumentException($"Vrijednost {nameof(Ime)} ne smije biti prazan string", nameof(value));
                    ime = value;
                }
            }


            // Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
            // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odgovarajući kod za hvatanje
            // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.
            private DateTime datumRođenja;

            public DateTime DatumRođenja
            {
                get => datumRođenja;
                set
                {
                    datumRođenja = value.Date > DateTime.Now.Date ?
                        throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(DatumRođenja)} mora biti manji od danasnjeg datuma")
                        : value;
                }
            }

        }

        // Definirati da je klasa OsobaSPromjenivimPrezimenom izvedena iz klase Osoba, ukloniti polja Ime i Prezime iz klase OsobaSPromjenivimPrezimenom 
        // te iz konstruktora inicijalizirati članove bazne klase.
        public class OsobaSPromjenivimPrezimenom : Osoba
        {
            //public string Ime;
            //public string Prezime;

            public OsobaSPromjenivimPrezimenom(string ime, string prezime) : base(ime, prezime)
            {
            }

            // Napraviti potrebne promjene svojstva Prezime u baznoj klasi Osoba da se iz metode UdajSe može promijeniti prezime osobe.
            // Napisati unutar metode UdajSe kod kojim se mijenja prezime osobe.
            public void UdajSe(string prezimePartnera)
            {
                Prezime = prezimePartnera;
            }
        }


        static void Main(string[] args)
        {
            // Provjeriti donjim kodom ispravnost promjena (zakomentirati naredbe koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba).

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

            // Pokrenuti program i provjeriti ispis za OsobuSPromjenivimPrezimenom.
            // Pokrenuti testove (5 testova u grupi "TestDefinicijeSvojstva" mora proći).
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