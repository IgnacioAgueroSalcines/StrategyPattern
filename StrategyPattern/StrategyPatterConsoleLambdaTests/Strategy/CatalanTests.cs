using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace StrategyPattern.Tests
{
    [TestClass()]
    public class CatalanTests
    {
        Estrategia catalana;
        

        [TestInitialize()]
        public void startUp()
        {
            catalana = new Catalan();
            
        }

        [TestMethod()]
        public void filtroTest()
        {
            String cadena = "apuñaló";
            String res = catalana.filtro(cadena);
            Assert.AreEqual(res,"apunyaló");
        }
    }
}