using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Vsite.CSharp.Svojstva.Testovi
{
    using Osoba = Vsite.CSharp.Svojstva.Definicija.Osoba;
    using OsobaSPromjenivimPrezimenom = Vsite.CSharp.Svojstva.Definicija.OsobaSPromjenivimPrezimenom;

    [TestClass]
    public class TestDefinicijeSvojstva
    {
        [TestMethod]
        public void PrezimeJeSvojstvoKojeSeMožeSamoČitati()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            Assert.AreEqual("Šafranek", o.Prezime);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("Prezime");
            Assert.IsNotNull(pi);
            Assert.IsTrue(!pi.CanWrite || pi.GetSetMethod(true).IsFamily || pi.GetSetMethod(true).IsPrivate || !pi.CanWrite);
            Assert.IsTrue(pi.CanRead);
        }

        [TestMethod]
        public void ImeJeSvojstvoKojeSeMožeČitatiAKodZadavanjaBacaIznimkuZaNulReferencu()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            Assert.AreEqual("Franjo", o.Ime);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("Ime");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);

            try
            {
                o.Ime = null;
                Assert.Fail();
            }
            catch (ArgumentNullException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ImeJeSvojstvoKojeSeMožeČitatiAKodZadavanjaBacaIznimkuZaPraznoIme()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            Assert.AreEqual("Franjo", o.Ime);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("Ime");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);

            try
            {
                o.Ime = "";
                Assert.Fail();
            }
            catch (ArgumentException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void DatumRođenjaJeSvojstvoKojeSeMožeČitatiAKodZadavanjaBacaIznimkuZaBudućiDatum()
        {
            Osoba o = new Osoba("Franjo", "Šafranek");
            o.DatumRođenja = new DateTime(1923, 12, 5);

            Type tipOsoba = typeof(Osoba);
            PropertyInfo pi = tipOsoba.GetProperty("DatumRođenja");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.CanRead);

            try
            {
                o.DatumRođenja = DateTime.Now.AddDays(3);
                Assert.Fail();
            }
            catch (ArgumentOutOfRangeException)
            {
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ProtectedSvojstvoSeMožeKoristitiIzIzvedeneKlase()
        {
            OsobaSPromjenivimPrezimenom o = new OsobaSPromjenivimPrezimenom("Ime", "Djevojačko prezime");

            Type tipOsoba = typeof(OsobaSPromjenivimPrezimenom);
            PropertyInfo pi = tipOsoba.GetProperty("Prezime");
            Assert.IsNotNull(pi);
            Assert.IsTrue(pi.DeclaringType == typeof(Osoba));
            Assert.IsTrue(pi.CanWrite);
            Assert.IsTrue(pi.DeclaringType == typeof(Osoba));
            Assert.IsTrue(pi.CanRead);
            Assert.IsTrue(pi.GetGetMethod(true).IsPublic);

            o.UdajSe("Muževo prezime");
            Assert.AreEqual("Muževo prezime", o.Prezime);
        }
    }
}
