using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using rojas.joaquin._2c.tp4;
namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IntanciarPaqueteTest()
        {
            Correo correo = new Correo();

            Assert.IsNotNull(correo.Paquetes);
        }

        [TestMethod]
        [ExpectedException(typeof(TrackingIdRepetidoException))]
        public void PaquerteRepetidoTest()
        {
            Correo correo = new Correo();
            Paquete paqueteUno = new Paquete("Euskadi 2962", "1234");
            Paquete paqueteDos = new Paquete("Chimentos 755", "1234");

            correo += paqueteUno;
            correo += paqueteDos;
        }
    }
}
