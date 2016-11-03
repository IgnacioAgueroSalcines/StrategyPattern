using Microsoft.VisualStudio.TestTools.UnitTesting;
using StrategyPattern;
using StrateyPatternConsole.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Tests
{
    [TestClass()]
    public class CastellanoTests
    {
        Estrategia  castellana;


        [TestInitialize()]
        public void startUp()
        {
            
            castellana = new Castellano();
        }

        [TestMethod()]
        public void filtroTest()
        {
            String cadena = "apuñaló";
            String res = castellana.filtro(cadena);
            Assert.AreEqual(res, "apuñaló");
        }
    }
}