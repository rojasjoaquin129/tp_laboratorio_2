using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace rojas.joaquin._2c.tp4
{
    public static class GuardaString
    {
        public static bool Guardar(this string texto,string Archivo)
        {
            bool retorno = false;
            string patch = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\{Archivo}";

            using (StreamWriter file = new StreamWriter(patch,true))
            {
                file.WriteLine(texto);
                retorno = true;
            }
            return retorno;
        }
    }
}
