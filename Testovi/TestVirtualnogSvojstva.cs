using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace Vsite.CSharp.Svojstva.Testovi
{
    using Student = Vsite.CSharp.Svojstva.VirtualnaSvojstva.Student;

    [TestClass]
    public class TestVirtualnogSvojstva
    {
        [TestMethod]
        public void UIzvedenojKlasiBitĆePozvanoNadglasujućeSvojstvo()
        {
            Student s = new Student("Pero", 3);
            Assert.AreEqual("Pero, 3. godina", s.Identifikacija);

            Type tipOsoba = typeof(Student);
            PropertyInfo pi = tipOsoba.GetProperty("Identifikacija");
            Assert.IsNotNull(pi);
            Assert.AreEqual(typeof(Student), pi.DeclaringType);
            MethodInfo mi = pi.GetMethod;
            Assert.IsTrue(mi.IsVirtual);
        }
    }
}
