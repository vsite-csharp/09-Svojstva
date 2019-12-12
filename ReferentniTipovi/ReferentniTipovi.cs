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
            //public IEnumerable<String> Namirnice { get => namirnice; }

            private List<string> namirnice = new List<string>(new string[] { "kruh", "mlijeko" });
        }


        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            s.Namirnice.Add("špek"); // dodajemo u smočnicu
            s.Namirnice[1] = "jogurt"; // mlijeko se zakiselilo

            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            Debug.Assert(s.Namirnice.Count() == 2);
            Debug.Assert(s.Namirnice[1] == "mlijeko");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
