using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // :020 Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.
        //public void PreopterećenoSvojstvo { get; set;  }
        //Ne može biti void, uvijek mora vrataći ili dohvaćati podatak 

        // :021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.

        //public int PreopterećenoSvojstvo { get; set;  } // Ne možemo isto ime svojstva koristiti za različite tipove argumenata 

        static void Main(string[] args)
        {
        }
    }
}
