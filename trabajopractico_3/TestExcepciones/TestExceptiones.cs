using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using EntidadesAbstractas;
using Clases_Instanciables;
namespace TestExcepciones
{
    [TestClass]
    public class TestExceptiones
    {
        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException()
        {
            Profesor alumno = new Profesor(5, "joaquin", "rojas", "99999999", Persona.ENacionalidad.Argentino);
        }

        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException()
        {
            Alumno alumno = new Alumno(5, "joaquin", "rojas", "9999afs9999", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
        }
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetidoException()
        {
            Universidad u = new Universidad();
            Alumno alumno = new Alumno(5, "joaquin", "rojas", "9999", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            Alumno alumno2 = new Alumno(2, "pepe", "Argento", "9999", Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);

            u += alumno;
            u += alumno2;
        }

        [TestMethod]
        [ExpectedException(typeof(SinProfesorException))]
        public void TestSinProfesorException()
        {
            Universidad uni = new Universidad();
            uni += Universidad.EClases.Programacion;
        }
        
       
    }
}
