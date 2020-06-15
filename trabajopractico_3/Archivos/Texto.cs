using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto:IArchivo<string>
    {
        #region METODO GUARDAR
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;
            StreamWriter streamWriter = null;
            try
            {

                streamWriter = new StreamWriter(archivo);
                streamWriter.WriteLine(datos);
                retorno = true;
            }
            catch (Exception ex)
            {
                throw new ArchivoException(ex);
            }
            finally
            {
                streamWriter.Close();
            }


            return retorno;
        }
        #endregion

        #region METODO LEER
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(archivo);
                datos = streamReader.ReadToEnd();
                retorno = true;
            }
            catch (Exception ex)
            {

                throw new ArchivoException(ex);
            }
            finally
            {
                streamReader.Close();
            }
            return retorno;
        }
        #endregion

    }
}
