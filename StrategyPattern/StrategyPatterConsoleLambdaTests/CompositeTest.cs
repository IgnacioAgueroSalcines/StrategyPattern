﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Composite;


namespace StrategyPatterConsoleLambdaTests
{
    /// <summary>
    /// Descripción resumida de CompositeTest
    /// </summary>
    [TestClass]
    public class CompositeTest
    {
        Composite.Composite composite;
        Archivo borrar;

        [TestInitialize()]
        public void startUp()
        {
            

            borrar = new Archivo("hoja4", 5,x=>x);
            composite = new Directorio("root", x => x);
            Composite.Composite composite2 = new Directorio("dir", x => x);
            Composite.Composite composite3 = new Comprimido("comp", x => x);


            composite3.addComponente(new Archivo("hoja1", 5, x => x));
            composite3.addComponente(new Archivo("hoja2", 5, x => x));

            composite2.addComponente(new Archivo("hoja3", 5, x => x));
            composite2.addComponente(composite3);

            EnlaceDirecto e = new EnlaceDirecto(composite2, x => x);

            composite.addComponente(borrar);
            composite.addComponente(composite2);
            composite.addComponente(e);


        }

        [TestMethod()]
        public void addComponenteTest()
        {

            int numeroHojas = composite.elementos();

            Assert.AreEqual(4, numeroHojas);
        }

        [TestMethod()]
        public void removeComponenteTest()
        {
            composite.removeComponente(borrar);
            int numeroHojas = composite.elementos();
            Assert.AreEqual(3, numeroHojas);


        }

        [TestMethod()]
        public void getTamanoTest()
        {

            int res = composite.getTamano();
            Assert.AreEqual(16, res);


        }

        [TestMethod()]
        public void elementosTest()
        {

            int res = composite.elementos();
            Assert.AreEqual(4, res);


        }
    }
}
