using System;
using System.Collections.Generic;
using System.Linq;

namespace Vsite.CSharp.Svojstva
{
    // primjer svojstava sa stringom kao parametrom
    class PoštanskiBrojevi
    {
        private Dictionary<int, string> popis = new Dictionary<int, string>()
        {
            { 10000, "Zagreb" },
            { 10360, "Sesvete" },
            { 10020, "Novi Zagreb" },
            { 21000, "Split" },
            { 31000, "Osijek" },
            { 41000, "Varaždin" },
            { 51000, "Rijeka" }
        };

        //  Definirati svojstvo s int kao parametrom koje će za zadani poštanski broj vratiti mjesto.
        public string this[int poštanskiBroj]
        {
            get => popis[poštanskiBroj];
        }


        // Definirati svojstvo sa string kao parametrom koje će za zadano mjesto vratiti poštanski broj.
        public int this[string mjesto]
        {
            get => popis.First(ključVrijednost => ključVrijednost.Value == mjesto).Key;
        }


    }

    class Indekseri
    {
        static PoštanskiBrojevi pb = new PoštanskiBrojevi();

        static void IspišiNazivMjesta(int poštanskiBroj)
        {
            //  Otkomentirati donju naredbu, pokrenuti program i provjeriti ispis.
            try
            {
                Console.WriteLine("Poštanski broj {0} ima: {1}", poštanskiBroj, pb[poštanskiBroj]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void IspišiPoštanskiBroj(string mjesto)
        {
            // Otkomentirati donju naredbu, pokrenuti program i provjeriti ispis.
            try
            {
                Console.WriteLine("Poštanski broj za {0} je: {1}", mjesto, pb[mjesto]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // TODO:044 Pokrenuti testove (2 testa "TestIndekseri" moraju proći).
        static void Main(string[] args)
        {
            IspišiNazivMjesta(21000);
            IspišiNazivMjesta(11111);
            IspišiPoštanskiBroj("Split");
            IspišiPoštanskiBroj("Nečujam");

            Console.WriteLine("GOTOVO!!!");
            Console.ReadKey(true);
        }
    }
}
