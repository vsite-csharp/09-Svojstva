using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    // kad preopterecuejmo metodu kompajler prepoznaje po tipu argumenata, a svojstva nemaju argumente
    class Preopterećenje
    {
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // :020 Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod.
      

        // :021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.
        

        static void Main(string[] args)
        {
        }
    }
}
