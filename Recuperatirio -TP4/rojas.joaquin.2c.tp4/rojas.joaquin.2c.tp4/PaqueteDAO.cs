using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace rojas.joaquin._2c.tp4
{
    public static class PaqueteDAO 
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        
        public delegate void DelegadoDAO();
        public static event DelegadoDAO ErrorDAO;


        static PaqueteDAO()
        {
            connection = new SqlConnection(@"data source = .\SQLEXPRESS; Database = correo-sp-2017 ; Trusted_Connection = True;");
            command = new SqlCommand();
            command.Connection = connection;
            command.CommandType = System.Data.CommandType.Text;
        }

        public static bool Insertar(Paquete p)
        {
            bool retorno = false;

            try
            {
                command.CommandText= "insert into Paquetes values (@direccionEntrega, @trackingID, @alumno)";

                command.Parameters.Clear();

                command.Parameters.Add(new SqlParameter("direccionEntrega", p.DireccionEntrega));
                command.Parameters.Add(new SqlParameter("trackingID", p.TrackingID));
                command.Parameters.Add(new SqlParameter("alumno", "Joaquin Rojas"));

                connection.Open();
            
                if (command.ExecuteNonQuery() == 1)
                {
                    retorno = true;
                }

            }
            catch (Exception )
            {

                PaqueteDAO.ErrorDAO();
            }
            finally
            {

                connection.Close();
            }
            return retorno;
        }
    }
}
