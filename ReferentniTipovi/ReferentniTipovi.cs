using System.Diagnostics;

namespace Vsite.CSharp.Svojstva
{
    class ReferentniTipovi
    {
        public class Smočnica
        {
            // :031 Promijeniti get metodu svojstva Namirnice tako da se onemogući promjena sadržaja liste izvan klase (tj. da naredbe Debug.Assert u metodi Main ne bacaju iznimke)
            public List<string> Namirnice
            {
                get { return new List<string>(namirnice); }
            }

            private List<string> namirnice = new List<string>(new string[] { "kruh", "mlijeko" });
        }
        // :032 Pokrenuti testove i provjeriti prolazi li test u grupi TestSvojstvaReferentnogTipa

        // :030 Prevesti i pokrenuti program te provjeriti mijenja li se sadržaj liste namirnica u smočnici.
        static void Main()
        {
            Smočnica s = new Smočnica();
            Console.WriteLine("Izvorna smočnica sadrži:");
            foreach (var a in s.Namirnice)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine();

            s.Namirnice.Add("špek"); // dodajemo u smočnicu

            s.Namirnice[1] = "jogurt"; // mlijeko se zakiselilo

            Console.WriteLine("Novi sadržaj smočnice:");
            foreach (var a in s.Namirnice)
            {
                Console.WriteLine(a);
            }

            // provjeravamo je li se sadržaj smočnice promijenio:
            Debug.Assert(s.Namirnice.Count() == 2);
            Debug.Assert(s.Namirnice[1] == "mlijeko");

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
