using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace Clases_Instanciables
{
    public sealed class Profesor : Universitario
    {
        #region ATRIBUTOS
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;
        #endregion

        #region CONSTRUCTORES
        static Profesor()
        {
            Profesor.random = new Random();
        }

        public Profesor()
        {

        }
        public Profesor(int id, string nombre, string apellido,
            string dni, ENacionalidad nacionalidad) : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
            this._randomClases();
        }
        #endregion

        #region METODOS
        private void _randomClases()
        {
            int clase = Profesor.random.Next(0, 3);
            this.clasesDelDia.Enqueue((Universidad.EClases)clase);
        }


        public override string ToString()
        {
            return this.MostrarDatos();
        }

        protected override string ParticiparEnClase()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine("CLASES DEL DÍA");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                mostrar.AppendLine(item.ToString());
            }

            return mostrar.ToString();
        }
        protected override string MostrarDatos()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendLine(base.MostrarDatos());
            mostrar.AppendLine(this.ParticiparEnClase());
            return mostrar.ToString();

        }
        #endregion

        #region OPERADORES
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;
            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    retorno = true;
                }
            }
            return retorno;
        }
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }
        #endregion
    }
}
