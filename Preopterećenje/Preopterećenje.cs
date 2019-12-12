using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        //public void VoidSvojstvo
        //{

        //}

        // svojstvo se ne može preopterećivati

        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // TODO:021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.

            //public int PreopterećenoSvojstvo
        //{
           // get { return 3; }
        //}



        static void Main(string[] args)
        {
        }
    }
}
