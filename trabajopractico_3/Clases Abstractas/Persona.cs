using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
namespace EntidadesAbstractas
{
    public abstract class Persona 
    {
        #region ATRIBUTOS
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;
        #endregion

        #region PROPIEDADES
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = ValidarNombreApellido(value);
            }
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string StringToDNI
        {
            set
            {
                this.dni = ValidarDni(this.nacionalidad, value);
            }

        }
        #endregion

        #region CONSTRUCTORES
        public Persona()
        {

        }
        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;

        }
        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.DNI = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad) : this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(string.Format("NOMBRE COMPLETO : {0} {1} ", this.Apellido, this.Nombre));
            mostrar.AppendLine(string.Format("NACIONALIDAD: {0} ", this.Nacionalidad.ToString()));
            return mostrar.ToString();

        }

        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int retorno = 0;
            switch (nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato > 1 && dato < 89999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException("la nacionalidad no se condice con el numero de DNI");
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato > 90000000 && dato < 99999999)
                    {
                        retorno = dato;
                    }
                    else
                    {
                        throw new NacionalidadInvalidaException("la nacionalidad no se condice con el numero de DNI");
                    }
                    break;
            }
            return retorno;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int retorno;
            if ((int.TryParse(dato, out retorno)))
            {
                retorno = ValidarDni(nacionalidad, retorno);
            }
            else
            {
                throw new DniInvalidoException();
            }
            return retorno;
        }
        private string ValidarNombreApellido(string dato)
        {
            string datoVerificado = string.Empty;
            int verificacionCaracteres = 0;
            foreach (char item in dato)
            {
                if (item >= 'A' && item <= 'Z' || item >= 'a' && item <= 'z')
                {
                    verificacionCaracteres++;

                }
            }
            if (verificacionCaracteres == dato.Length)
            {
                datoVerificado = dato;
            }
            return datoVerificado;
        }
        #endregion

        #region ENUMERADO
        public enum ENacionalidad
        {
            Argentino, Extranjero
        }
        #endregion

    }
}
