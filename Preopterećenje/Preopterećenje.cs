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
        //public void VoidSvojstvo; // Ova deklaracija neće proći kompilaciju

        // :021 Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int i pokušati prevesti kod.
        // public int PreopterećenoSvojstvo; // Ova deklaracija neće proći kompilaciju
        static void Main()
        {
        }
    }
}
