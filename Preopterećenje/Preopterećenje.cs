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

        static void Main(string[] args)
        {
        }
    }
}
