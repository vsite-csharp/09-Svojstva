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

        // TODO:020 Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.

        // TODO:021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.

        static void Main(string[] args)
        {
        }
    }
}
