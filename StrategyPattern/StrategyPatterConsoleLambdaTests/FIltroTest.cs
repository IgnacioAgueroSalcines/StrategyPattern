using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;
using System.Text.RegularExpressions;

namespace StrategyPatterConsoleLambdaTests
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class FiltroTest
    {
        Composite.Composite composite2;
        Composite.Composite composite3;
        Componente hoja;
        Componente e;

        /// <summary>
        /// Elimina los acentos de una cadena
        /// </summary>
        /// <param name="inputString">Texto con acentos</param>
        /// <returns>Texto sin acentos</returns>
        public string QuitAccents(string inputString)
        {
            Regex a = new Regex("[á|à|ä|â]", RegexOptions.Compiled);
            Regex e = new Regex("[é|è|ë|ê]", RegexOptions.Compiled);
            Regex i = new Regex("[í|ì|ï|î]", RegexOptions.Compiled);
            Regex o = new Regex("[ó|ò|ö|ô]", RegexOptions.Compiled);
            Regex u = new Regex("[ú|ù|ü|û]", RegexOptions.Compiled);
            Regex n = new Regex("[ñ|Ñ]", RegexOptions.Compiled);
            inputString = a.Replace(inputString, "a");
            inputString = e.Replace(inputString, "e");
            inputString = i.Replace(inputString, "i");
            inputString = o.Replace(inputString, "o");
            inputString = u.Replace(inputString, "u");
            inputString = n.Replace(inputString, "n");
            return inputString;
        }

        [TestMethod]
        public void TestCatalana()
        {
            composite2 = new Directorio("apuñaló", x => x.Replace("ñ","ny"));
            composite3 = new Comprimido("apuñaló", x => x.Replace("ñ", "ny"));
            hoja = new Archivo("apuñaló", 5, x => x.Replace("ñ", "ny"));
            e = new EnlaceDirecto(composite2, x => x.Replace("ñ", "ny"));

            Assert.AreEqual(composite2.ToString(), "apunyaló");
            Assert.AreEqual(composite3.ToString(), "apunyaló");
            Assert.AreEqual(hoja.ToString(), "apunyaló");
            Assert.AreEqual(e.ToString(), "apunyaló");
        }

        [TestMethod]
        public void TestGallega()
        {
            composite2 = new Directorio("apuñaló", x => x.Replace("ñ", "nh"));
            composite3 = new Comprimido("apuñaló", x => x.Replace("ñ", "nh"));
            hoja = new Archivo("apuñaló", 5, x => x.Replace("ñ", "nh"));
            e = new EnlaceDirecto(composite2, x => x.Replace("ñ", "nh"));

            Assert.AreEqual(composite2.ToString(), "apunhaló");
            Assert.AreEqual(composite3.ToString(), "apunhaló");
            Assert.AreEqual(hoja.ToString(), "apunhaló");
            Assert.AreEqual(e.ToString(), "apunhaló");
        }

        [TestMethod]
        public void TestIntCatalana()
        {
            composite2 = new Directorio("apuñaló", x => QuitAccents(x.Replace("ñ", "ny")));
            composite3 = new Comprimido("apuñaló", x => QuitAccents(x.Replace("ñ", "ny")));
            hoja = new Archivo("apuñaló", 5, x => QuitAccents(x.Replace("ñ", "ny")));
            e = new EnlaceDirecto(composite2, x => QuitAccents(x.Replace("ñ", "ny")));

            Assert.AreEqual(composite2.ToString(), "apunyalo");
            Assert.AreEqual(composite3.ToString(), "apunyalo");
            Assert.AreEqual(hoja.ToString(), "apunyalo");
            Assert.AreEqual(e.ToString(), "apunyalo");
        }

        [TestMethod]
        public void TestIntGallega()
        {
            composite2 = new Directorio("apuñaló", x => QuitAccents(x.Replace("ñ", "nh")));
            composite3 = new Comprimido("apuñaló", x => QuitAccents(x.Replace("ñ", "nh")));
            hoja = new Archivo("apuñaló", 5, x => QuitAccents(x.Replace("ñ", "nh")));
            e = new EnlaceDirecto(composite2, x => QuitAccents(x.Replace("ñ", "nh")));

            Assert.AreEqual(composite2.ToString(), "apunhalo");
            Assert.AreEqual(composite3.ToString(), "apunhalo");
            Assert.AreEqual(hoja.ToString(), "apunhalo");
            Assert.AreEqual(e.ToString(), "apunhalo");
        }
    }
}
