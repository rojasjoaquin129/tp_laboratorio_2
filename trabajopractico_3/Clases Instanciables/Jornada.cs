using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;

namespace Clases_Instanciables
{
    public class Jornada
    {
        #region ATRIBUTOS
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;
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

        public Universidad.EClases Clases
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        #endregion

        #region CONSTRUCTORES
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instrutor) : this()
        {
            this.Clases = clase;
            this.Instructor = instrutor;
        }
        #endregion

        #region METODOS
        public override string ToString()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(string.Format("CLASE DE {0} POR {1}", this.clase.ToString(), this.instructor.ToString()));
            mostrar.AppendLine("ALUMNOS");
            foreach (Alumno item in this.alumnos)
            {
                mostrar.AppendLine(item.ToString());
            }
            return mostrar.ToString();
        }

        public static bool Guardar(Jornada jornada)
        {
            Texto texto = new Texto();
            string direccion = Directory.GetCurrentDirectory() + @"\Jornada.txt";
            bool retorno = false;
            if (texto.Guardar(direccion, jornada.ToString()))
            {
                retorno = true;
            }
            return retorno;
        }

        public static string Leer()
        {
            Texto texto = new Texto();
            string direccion = Directory.GetCurrentDirectory() + @"\Jornada.txt";
            texto.Leer(direccion, out string datosJornada);
            return datosJornada;
        }
        #endregion

        #region OPERADORES
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
            {
                j.alumnos.Add(a);
            }
            return j;

        }
        public static bool operator ==(Jornada j, Alumno a)
        {
            bool retorno = false;
            foreach (Alumno item in j.alumnos)
            {
                if (item == a)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }
        #endregion

    }
}
