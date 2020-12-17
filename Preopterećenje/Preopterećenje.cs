using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        // TODO:020 Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.

        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }
        // TODO:021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.
        //public int PrSv

        static void Main(string[] args)
        {
        }
    }
}
