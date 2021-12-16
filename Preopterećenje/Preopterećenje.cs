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

        // Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod. -> nema što vraćati ni postavljati
        //public void VoidSvojstvo { get; set; }

        // Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod. -> nema argument
        //public int PreopterećenoSvojstvo { get; set; }

        static void Main(string[] args)
        {
        }
    }
}
