using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vsite.CSharp;
using System.Reflection;

namespace Vsite.CSharp.Svojstva.Testovi
{
    [TestClass]
    public class TestIndeksera
    {
        [TestMethod]
        public void ZaImeMjestaDefiniranJeIndekserSaCijelimBrojem()
        {
            Type tipPoštanskiBrojevi = typeof(PoštanskiBrojevi);
            PropertyInfo[] properties = tipPoštanskiBrojevi.GetProperties();
            PropertyInfo property = properties.First(pi => pi.Name == "Item" && pi.PropertyType == typeof(string));
            Assert.IsNotNull(property);

            ParameterInfo[] parameters = property.GetIndexParameters();
            Assert.AreEqual(1, parameters.Count());
            Assert.AreEqual(typeof(int), parameters[0].ParameterType);

            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);
        }

        [TestMethod]
        public void ZaPoštanskiBrojDefiniranJeIndekserSaStringom()
        {
            Type tipPoštanskiBrojevi = typeof(PoštanskiBrojevi);
            PropertyInfo[] properties = tipPoštanskiBrojevi.GetProperties();
            PropertyInfo property = properties.First(pi => pi.Name == "Item" && pi.PropertyType == typeof(int));
            Assert.IsNotNull(property);

            ParameterInfo[] parameters = property.GetIndexParameters();
            Assert.AreEqual(1, parameters.Count());
            Assert.AreEqual(typeof(string), parameters[0].ParameterType);

            Assert.IsFalse(property.CanWrite);
            Assert.IsTrue(property.CanRead);
        }
    }
}
