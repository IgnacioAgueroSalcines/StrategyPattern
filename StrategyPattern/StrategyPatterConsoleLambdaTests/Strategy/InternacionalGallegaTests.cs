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
    public class InternacionalGallegaTests
    {
        Estrategia intGallega;


        [TestInitialize()]
        public void startUp()
        {
            intGallega = new InternacionalGallega();
        }

        [TestMethod()]
        public void filtroTest()
        {
            String cadena = "apuñaló";
            String res = intGallega.filtro(cadena);
            Assert.AreEqual(res, "apunhalo");
        }
    }
}