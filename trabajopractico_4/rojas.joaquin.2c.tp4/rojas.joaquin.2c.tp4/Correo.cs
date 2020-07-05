using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace rojas.joaquin._2c.tp4
{
    public class Correo : IMostar<List<Paquete>>
    {
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;

        public List<Paquete>  Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        public void FinEntregas()
        {
            foreach (Thread item in mockPaquetes)
            {
                item.Abort();
            }
        }
        public string MostrarDatos(IMostar<List<Paquete>> elemento)
        {
            StringBuilder mostrar = new StringBuilder();
            foreach (Paquete item in ((Correo)elemento).paquetes)
            {
                mostrar.AppendLine(string.Format("{0}  ({1})",item.ToString(),item.Estado));
            }
            return mostrar.ToString();
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.paquetes)
            {
                if (item==p)
                {
                    throw new TrackingIdRepetidoException("El paquete se ya se encuentra en la lista");
                }
            }
            Thread hilo = new Thread(p.MockCicloDeVida);
            c.mockPaquetes.Add(hilo);
            c.paquetes.Add(p);
            
            hilo.Start();

            return c;
        }
        



    }
}
