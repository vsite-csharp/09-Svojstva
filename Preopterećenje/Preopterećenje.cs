using System;

namespace Vsite.CSharp.Svojstva
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {


        // svojstvo se ne može preopterećivati

        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }


        //    public int PreopterećenoSvojstvo
        //{
        //    get { return 3; }
        //}


        static void Main(string[] args)
        {
        }
    }
}
