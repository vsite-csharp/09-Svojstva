﻿using System.Diagnostics;

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

            // TODO:010 Nadglasati (overrideati) svojstvo Identifikacija tako da get metoda vraća znakovni niz oblika: "Pero, 2. godina".



            public int Godina { get; set; }
        }

        // TODO:011 Pokrenuti program i provjeriti ispis.

        // TODO:012 Pokrenuti testove (test u grupi "TestVirtualnogSvojstva" mora proći).

        static void Main()
        {
            Osoba o = new Osoba("Janko");
            Console.WriteLine(o.Identifikacija);

            Student s = new Student("Pero", 5);
            Debug.Assert(s.Identifikacija == "Pero, 5. godina");
            Console.WriteLine(s.Identifikacija);

            Console.WriteLine("GOTOVO!!!");
        }
    }
}
