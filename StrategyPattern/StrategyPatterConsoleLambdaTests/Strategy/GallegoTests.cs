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
    public class GallegoTests
    {
        Estrategia  gallega;


        [TestInitialize()]
        public void startUp()
        {
            gallega = new Gallego();
        }

        [TestMethod()]
        public void filtroTest()
        {
            String cadena = "apuñaló";
            String res = gallega.filtro(cadena);
            Assert.AreEqual(res, "apunhaló");
        }
    }
}