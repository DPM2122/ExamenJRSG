using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ExamenNS;

namespace TestExamen
{
    [TestClass]
    public class UnitTest1
    {
        public const string NoMultiplo10 = "La cantidad ha de ser multiplo de 10";
        public const string NumeroNegativo = "La cantidad no puede ser negativa";

        [TestMethod]
        public void PruebaCorrectos()
        {
            Billetes prueba = new Billetes();
            int cantidad = 580;
            prueba.EstablecerCantidad(cantidad);
            int ResBilletes50 = 11;
            int ResBilletes20 = 1;
            int ResBilletes10 = 1;

            Assert.AreEqual(ResBilletes50, prueba.Billetes50, "Error");
            Assert.AreEqual(ResBilletes20, prueba.Billetes20, "Error");
            Assert.AreEqual(ResBilletes10, prueba.Billetes10, "Error");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), NoMultiplo10)]
        public void PruebaCantidadNoValida()
        {
            Billetes prueba = new Billetes();
            int cantidad = 581;
            prueba.EstablecerCantidad(cantidad);
        }

        [TestMethod]
        public void PruebaCantidadNoValidaTryCatch()
        {
            Billetes prueba = new Billetes();
            int cantidad = 581;
            try
            {
                prueba.EstablecerCantidad(cantidad);
            }
            catch(ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, NoMultiplo10);
                return;
            }
            Assert.Fail("Error");
        }

        [TestMethod]
        [ExpectedException(typeof(Exception), NumeroNegativo)]
        public void PruebaNuemrosNegativos()
        {
            Billetes prueba = new Billetes();
            int cantidad = -580;
            prueba.EstablecerCantidad(cantidad);
        }
    }
}
