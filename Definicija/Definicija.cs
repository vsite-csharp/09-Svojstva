using System;

namespace Vsite.CSharp.Svojstva
{
    class Definicija
    {
        public class Osoba
        {
            public Osoba(string ime, string prezime)
            {
                this.ime = ime;
                this.prezime = prezime;
            }

            private string prezime;
            
            public string Prezime
            {
                get; protected set;
            }

            private string ime;

            public string Ime
            {
                get => ime;
                set{
                    //ili set => ime = value ?? throw new ArgumentNullException($"{ nameof(value) } must not be null reference");
                    if (value == null)
                        throw new ArgumentNullException($"{ nameof(value) } must not be null reference");
                    if (value.Length == 0)
                        throw new ArgumentNullException($"{ nameof(value) } must not be empty");
                    ime = value;
                }
            }


            // TODO:002 Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
            // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
            // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.

            private DateTime datumRođenja;

            public DateTime DatumRođenja
            {
                get => datumRođenja;
                set{
                    if (value.Date > DateTime.Now.Date)
                        throw new ArgumentOutOfRangeException($"{ nameof(value) } must not be less than...");
                    datumRođenja = value;
                }
            }

        }
        public class OsobaSPromjenivimPrezimenom : Osoba
        {
            public OsobaSPromjenivimPrezimenom(string ime, string prezime) : base(ime, prezime)
            { }

            // TODO:005 Napraviti potrebne promjene svojstva Prezime u baznoj klasi Osoba da se iz metode UdajSe može promijeniti prezime osobe.
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

            try
            {
                o1.DatumRođenja = new DateTime(2025, 4, 13);
                Console.WriteLine(o1.DatumRođenja.ToShortDateString());
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
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
