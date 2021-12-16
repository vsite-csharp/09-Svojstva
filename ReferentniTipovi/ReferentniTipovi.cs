using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Vsite.CSharp.Svojstva
{
    class ReferentniTipovi
    {
        public class Smočnica
        {
            // TODO:031 Promijeniti get metodu svojstva Namirnice tako da se onemogući promjena sadržaja liste izvan klase (tj. da naredbe Debug.Assert u metodi Main ne bacaju iznimke)
            //public List<string> Namirnice
            //{
                //get { return namirnice; }
             //   get { return new List<string>(namirnice); }
           // }
            public IEnumerable<string> Namirnice => namirnice;

            private List<string> namirnice = new List<string>(new string[] { "kruh", "mlijeko" });
        }
            // Pokrenuti testove i provjeriti prolazi li test u grupi TestSvojstvaReferentnogTipa

        // Prevesti i pokrenuti program te provjeriti mijenja li se sadržaj liste namirnica u smočnici.
        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            Console.WriteLine("Izvorna smočnica sadrži:");
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);
            Console.WriteLine();

            //s.Namirnice.Add("špek"); // dodajemo u smočnicu

            //s.Namirnice[1] = "jogurt"; // mlijeko se zakiselilo

            Console.WriteLine("Novi sadržaj smočnice:");
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            // provjeravamo je li se sadržaj smočnice promijenio:
            Debug.Assert(s.Namirnice.Count() == 2);
            Debug.Assert(s.Namirnice.ElementAt(1) == "mlijeko");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
