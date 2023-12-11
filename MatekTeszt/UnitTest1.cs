using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tesztelgetunk;
using FluentAssertions;

namespace MatekTeszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOsszead()
        {
            Matek mt = new Matek();

            int resultOsszead = mt.Osszead(10, 10);

            Assert.AreEqual(resultOsszead, 20);
        }

        [TestMethod]
        public void TestSzorzas()
        {
            Matek mt = new Matek();

            int resultSzorzas = mt.Szorzas(10, 10);

            Assert.AreEqual(resultSzorzas, 100);
        }
        
        [TestMethod]
        public void TestOsztas()
        {
            Matek mt = new Matek();

            double resultOsztas = mt.Osztas(10, 20);

            Assert.AreEqual(resultOsztas, 0.5);
        }
        
        [TestMethod]
        public void TestOsszead_2()
        {
            Matek mt = new Matek();

            int resultOsszeg = mt.Osszead(10, 10);

            resultOsszeg.Should().Be(200);
        }
    }
}
