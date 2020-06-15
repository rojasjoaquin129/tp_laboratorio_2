using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
namespace Clases_Instanciables
{
    public  sealed class Alumno:Universitario
    {
        #region ATRIBUTOS
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;
        #endregion

        #region CONSTRUCTORES
        public Alumno()
        {

        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            return this.MostrarDatos();
        }
        protected override string MostrarDatos()
        {
            StringBuilder mostrar = new StringBuilder();

            mostrar.AppendLine(base.MostrarDatos());
            mostrar.AppendLine(string.Format("ESTADO DE CUENTA {0}", this.estadoCuenta.ToString()));
            mostrar.AppendLine(this.ParticiparEnClase());
            return mostrar.ToString();

        }
        protected override string ParticiparEnClase()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(string.Format("TOMA CLASE DE {0}", this.claseQueToma.ToString()));
            return mostrar.ToString(); ;
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Alumno alumno, Universidad.EClases clase)
        {
            bool retorno = false;
            if (alumno.claseQueToma == clase && alumno.estadoCuenta != EEstadoCuenta.Deudor)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Alumno alumno, Universidad.EClases clase)
        {
            return !(alumno == clase);
        }

        #endregion

        #region ENUMERADOS
        public enum EEstadoCuenta
        {
            AlDia, Deudor, Becado
        }
        #endregion

    }
}
