using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    [TestClass()]
    public class InternacionalCatalanTests
    {
        Estrategia intCatalana;


        [TestInitialize()]
        public void startUp()
        {
           
            intCatalana = new InternacionalCatalan();
        }

        [TestMethod()]
        public void filtroTest()
        {
            String cadena = "apuñaló";
            String res = intCatalana.filtro(cadena);
            Assert.AreEqual(res, "apunyalo");
        }
    }
}