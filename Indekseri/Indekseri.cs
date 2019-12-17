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


        public string this[int br]
        {
            get
            {
                return popis[br];
            }
        }

        public int this[string br]
        {
            get
            {
                if (popis.ContainsValue(br))
                    return popis.FirstOrDefault(x => x.Value == br).Key;
                else
                    throw new Exception($"{br} does not exist in dictionary.");
            }
        }

    }

    class Indekseri
    {
        static PoštanskiBrojevi pb = new PoštanskiBrojevi();

        static void IspišiNazivMjesta(int poštanskiBroj)
        {
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
            try
            {
                Console.WriteLine("Poštanski broj za {0} je: {1}", mjesto, pb[mjesto]);
            }
            catch (System.Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


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
