using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases_Instanciables;


namespace TestExcepciones
{
    /// <summary>
    /// Descripción resumida de UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
  
        [TestMethod]
        public void TestInstanciarUniversidad()
        {
            Universidad uni = new Universidad();

            Assert.IsNotNull(uni.Alumnos);
            
        }

    }
}
