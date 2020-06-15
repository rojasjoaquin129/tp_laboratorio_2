using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region ATRIBUTOS
        private int legajo;
        #endregion

        #region CONTRUCTORES
        public Universitario()
        {

        }
        public Universitario(int legajo, string nombre, string apellido,
            string dni, ENacionalidad nacionalidad) : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }
        #endregion

        #region METODOS
        protected virtual string MostrarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(base.ToString());
            mostrar.AppendLine(string.Format("LEGAJO: {0} ", this.legajo));
            return mostrar.ToString();
        }
        protected abstract string ParticiparEnClase();
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if (obj is Universitario)
            {
                if ((this.DNI == ((Universitario)obj).DNI) || (this.legajo == ((Universitario)obj).legajo))
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Universitario objUno, Universitario objDos)
        {
            bool retorno = false;
            if (objUno.Equals(objDos))
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Universitario objUno, Universitario objDos)
        {
            return !(objUno == objDos);
        }
        #endregion

    }
}
