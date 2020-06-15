using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
using System.IO;

namespace Clases_Instanciables
{
    public class Universidad
    {
        #region ATRIBUTOS
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;
        #endregion

        #region PROPIEDADES
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        public Jornada this[int i]
        {
            get
            {
                return this.jornada[i];
            }
            set
            {
                this.jornada[i] = value;
            }
        }

        #endregion

        #region CONSTRUCTORES
        public Universidad()
        {
            this.Profesores = new List<Profesor>();
            this.Jornadas = new List<Jornada>();
            this.Alumnos = new List<Alumno>();

        }
        #endregion

        #region METODOS
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("JORNADA:");
            foreach (Jornada item in uni.jornada)
            {
                mostrar.AppendLine(item.ToString());
                mostrar.AppendLine("<--------------------------------------->");
            }
            return mostrar.ToString();
        }

        public override string ToString()
        {
            return Universidad.MostrarDatos(this);
        }
        public static bool Guardar(Universidad uni)
        {
            string direccion = Directory.GetCurrentDirectory() + @"\Universidad.xml";
            Xml<Universidad> XmlUni = new Xml<Universidad>();
            bool retorno = false;
            if (XmlUni.Guardar(direccion, uni))
            {
                retorno = true;
            }
            return retorno;
        }

        public static Universidad Leer()
        {
            string direccion = Directory.GetCurrentDirectory() + @"\Universidad.xml";
            Xml<Universidad> XmlUni = new Xml<Universidad>();
            XmlUni.Leer(direccion, out Universidad uni);
            return uni;
        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Universidad g, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno item in g.Alumnos)
            {
                if (item == a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Universidad g, Alumno a)
        {
            return !(g == a);
        }

        public static bool operator ==(Universidad g, Profesor i)
        {

            bool retorno = false;
            foreach (Profesor item in g.Profesores)
            {
                if (item == i)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Universidad g, Profesor i)
        {
            return !(g == i);
        }
        public static Profesor operator ==(Universidad g, EClases clase)
        {
            bool retorno = false; ;
            Profesor profesor = null;
            foreach (Profesor item in g.Profesores)
            {
                if (item == clase)
                {
                    profesor = item;
                    retorno = true;
                    break;
                }
            }
            if (!(retorno))
            {
                throw new SinProfesorException();
            }
            return profesor;
        }
        public static Profesor operator !=(Universidad g, EClases clase)
        {
            bool retorno = false; ;
            Profesor profesor = null;
            foreach (Profesor item in g.Profesores)
            {
                if (item != clase)
                {
                    profesor = item;
                    retorno = true;
                    break;
                }
            }
            if (!(retorno))
            {
                throw new SinProfesorException();
            }
            return profesor; ;
        }

        public static Universidad operator +(Universidad u, EClases clase)
        {
            Jornada jornada = new Jornada(clase, (u == clase));
            foreach (Alumno item in u.Alumnos)
            {
                if (item == clase)
                {
                    jornada += item;
                }
            }
            u.Jornadas.Add(jornada);
            return u;
        }

        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
            {
                u.Alumnos.Add(a);
            }
            else
            {
                throw new AlumnoRepetidoException();
            }
            return u;
        }
        public static Universidad operator +(Universidad u, Profesor i)
        {
            if (u != i)
            {
                u.Profesores.Add(i);
            }
            return u;
        }
        #endregion

        #region ENUMERADO
        public enum EClases
        {
            Programacion, Laboratorio, Legislacion, SPD
        }
        #endregion

    }
}
