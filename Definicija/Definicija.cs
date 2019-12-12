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
                this.Prezime = prezime;
            }

            public string Prezime { get; protected set; }
            
            private string ime;
            public string Ime
            {
                get => ime;
                //set => ime = (value ?? throw new ArgumentNullException($"{nameof(value)} must not be null reference")).Length > 0 ? value : throw new ArgumentException($"{nameof(value)}Ime cant be empty");
                set
                {
                    if (value == null)
                        throw new ArgumentNullException($"{nameof(value)} must not be null reference");

                    if (value.Length == 0)
                        throw new ArgumentException($"{nameof(value)}Ime cant be empty");

                    ime = value;
                }
            }
            private DateTime datumRođenja;
            public DateTime DatumRođenja
            {
                get => datumRođenja;

                set
                {
                    if(value.Date > DateTime.Now.Date)
                        throw new ArgumentOutOfRangeException($"{nameof(value)} must not be after today");
                    datumRođenja = value.Date;
                }
            }
          

        }

        public class OsobaSPromjenivimPrezimenom : Osoba
        {
            //public string Ime;
            //public string Prezime;
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
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Write(ex.Message);
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
