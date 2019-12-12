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
                this.Prezime = prezime;
            }

            public string Prezime { get; protected set; }



            private string ime;

            public string Ime
            {
                get => ime; 
                set
                {
                    //ime = (value ?? throw new ArgumentNullException($"{nameof(value)} must not be null reference")).Length > 0 ? value : throw new ArgumentException($"{nameof(value)} must not be empty");
                    if (value == null)
                    {
                        throw new ArgumentNullException($"{nameof(value)} must not be null reference");
                    }
                    if (value.Length == 0)
                    {
                        throw new ArgumentException($"{nameof(value)} must not be empty");
                    }
                    ime = value;
                }
            }


           

            private DateTime DatumRođenja;

            public DateTime DatumRodenja
            {
                get => DatumRodenja;
                set
                {
                    if (value.Date > DateTime.Now.Date)
                        throw new ArgumentOutOfRangeException($"{nameof(value)} must not be ...");
                    DatumRodenja = value;
                }
            }



        }

        public class OsobaSPromjenivimPrezimenom :Osoba
        {
            public string Ime;
            public string Prezime;

            public OsobaSPromjenivimPrezimenom(string ime, string prezime) : base(ime,prezime)
            { }

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

            o1.DatumRodenja = new DateTime(1933, 4, 13);
            Console.WriteLine(o1.DatumRodenja.ToShortDateString());

            o1.Ime = "Pero";
           // o1.Prezime = "Kvrgić";
            Console.WriteLine($"{o1.Ime} {o1.Prezime}");
            try
            {
                o1.DatumRodenja = new DateTime(2025, 4, 13);
                Console.WriteLine(o1.DatumRodenja.ToShortDateString());
            }
            catch(ArgumentOutOfRangeException e)
            {
                Console.WriteLine("ne valja ti datum");
            }

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
