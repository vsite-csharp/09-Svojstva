using System.Reflection;

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

            Type tipSmočnica = typeof(Smočnica);
            PropertyInfo? pi = tipSmočnica.GetProperty("Namirnice");
            Assert.IsNotNull(pi);
            if (pi.PropertyType == typeof(List<string>))
            {
                pi.PropertyType.GetMethod("Add")?.Invoke(s.Namirnice, new object[] { "kulen" });
                Assert.AreEqual(brojNamirnica, s.Namirnice?.Count());
            }
            else
                Assert.AreEqual(pi.PropertyType, typeof(IEnumerable<string>));
        }
    }
}
