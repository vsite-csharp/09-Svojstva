using System;
using System.Diagnostics;

namespace Vsite.CSharp.Svojstva
{
    class VirtualnaSvojstva
    {
        public class Osoba
        {
            public Osoba(string ime)
            {
                Identifikacija = ime;
            }

            public virtual string Identifikacija
            {
                get;
                private set;
            }
        }

        public class Student : Osoba
        {
            public Student(string ime, int godina) : base(ime)
            {
                Godina = godina;
            }

            // Nadglasati (overrideati) svojstvo Identifikacija tako da get metoda vraća znakovni niz oblika: "Pero, 2. godina".
            public override string Identifikacija => base.Identifikacija + $", {Godina}. godina";



            public int Godina { get; set; }
        }

        //  Pokrenuti program i provjeriti ispis.

        //  Pokrenuti testove (test u grupi "TestVirtualnogSvojstva" mora proći).

        static void Main(string[] args)
        {
            Osoba o = new Osoba("Janko");
            Console.WriteLine(o.Identifikacija);

            Student s = new Student("Pero", 5);
            Debug.Assert(s.Identifikacija == "Pero, 5. godina");
            Console.WriteLine(s.Identifikacija);

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}