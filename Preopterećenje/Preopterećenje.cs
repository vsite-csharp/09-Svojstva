using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        // Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.
        //public VoidSvojstvo { get; set; }
        //nemoze se
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }
        // Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.
        /*public int PreopterećenoSvojstvo
        {
            get { return 3; }
        }*/

        static void Main(string[] args)
        {
        }
    }
}
