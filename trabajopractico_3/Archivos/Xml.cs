using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;

namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        #region METODO GUARDAR
        public bool Guardar(string archivo, T datos)
        {
            bool retorno = false;
            XmlTextWriter xmlTextWriter = null;
            XmlSerializer xmlSerializer = null;
            try
            {
                xmlTextWriter = new XmlTextWriter(archivo, Encoding.UTF8);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlSerializer = new XmlSerializer(typeof(T));
                xmlSerializer.Serialize(xmlTextWriter, datos);
                retorno = true;
            }
            catch (Exception ex)
            {

                throw new ArchivoException(ex);
            }
            finally
            {
                xmlTextWriter.Close();
            }
            return retorno;
        }
        #endregion

        #region METODO LEER
        public bool Leer(string archivo, out T datos)
        {
            bool retorno = false;
            XmlTextReader xmlTextReader = null;
            XmlSerializer xmlSerializer = null;
            try
            {
                xmlTextReader = new XmlTextReader(archivo);
                xmlSerializer = new XmlSerializer(typeof(T));
                datos = (T)xmlSerializer.Deserialize(xmlTextReader);
                retorno = true;
            }
            catch (Exception ex)
            {

                throw new ArchivoException(ex);
            }
            finally
            {
                xmlTextReader.Close();

            }
            return retorno;
        }
        #endregion

    }
}
