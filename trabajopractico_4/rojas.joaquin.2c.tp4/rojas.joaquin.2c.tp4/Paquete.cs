using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rojas.joaquin._2c.tp4
{
    public class Paquete : IMostar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public string  DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }

        public string  TrackingID
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }

        public EEstado  Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public Paquete(string dirreccion , string trackingID)
        {
            this.direccionEntrega = dirreccion;
            this.trackingID = trackingID;
        }

        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(4000);
                this.Estado++;
                this.InfomaEstado(this, null);
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception ex)
            {

                throw new Exception("Error en metodo : MockCicloDeVida , clase : Paquetes ", ex);
            }
        }
        public string MostrarDatos(IMostar<Paquete> elemento)
        {
            string mostrar= string.Format("{0} para {1}",((Paquete)elemento).DireccionEntrega,((Paquete)elemento).TrackingID);
            return mostrar;
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;
            if (p1.trackingID == p2.trackingID)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return MostrarDatos(this);
        }

        public event DelegadoEstado InfomaEstado;

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public enum EEstado
        {
            Ingresado ,EnViaje , Entregado
        }

    }
}
