using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Vsite.CSharp.Svojstva.Testovi
{
    using Smočnica = Vsite.CSharp.Svojstva.ReferentniTipovi.Smočnica;

    [TestClass]
    public class TestSvojstvaReferentnogTipa
    {
        [TestMethod]
        public void GetSvojstvoVraćaKopijuPaOnemogućujePromjenuSadržaja()
        {
            Smočnica s = new Smočnica();
            int brojNamirnica = s.Namirnice.Count();
            s.Namirnice.Add("kulen");
            Assert.AreEqual(brojNamirnica, s.Namirnice.Count());
        }
    }
}
