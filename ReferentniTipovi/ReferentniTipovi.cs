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
            
            public List<string> Namirnice
            {
                get { return new List<string>(namirnice); }
            }

            private List<string> namirnice = new List<string>(new string[] { "kruh", "mlijeko" });
        }

        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            Console.WriteLine("Izvorna smočnica sadrži:");
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);
            Console.WriteLine();

            s.Namirnice.Add("špek"); // dodajemo u smočnicu

            s.Namirnice[1] = "jogurt"; // mlijeko se zakiselilo

            Console.WriteLine("Novi sadržaj smočnice:");
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            // provjeravamo je li se sadržaj smočnice promijenio:
            Debug.Assert(s.Namirnice.Count() == 2);
            Debug.Assert(s.Namirnice[1] == "mlijeko");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
