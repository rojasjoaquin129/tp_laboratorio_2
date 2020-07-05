using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using rojas.joaquin._2c.tp4;


namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        private Correo correo;
        public FrmPpal()
        {
            InitializeComponent();
            this.correo = new Correo();
        }

        private void ActualizarEstados()
        {
            this.lstEstadoIngresado.Items.Clear();
            this.lstEstadoEnViaje.Items.Clear();
            this.lstEstadoEntregado.Items.Clear();
            foreach (Paquete item in this.correo.Paquetes)
            {
                switch (item.Estado)
                {
                    case Paquete.EEstado.Ingresado:
                        this.lstEstadoIngresado.Items.Add(item);
                        break;
                    case Paquete.EEstado.EnViaje:
                        this.lstEstadoEnViaje.Items.Add(item);
                        break;
                    case Paquete.EEstado.Entregado:
                        this.lstEstadoEntregado.Items.Add(item);
                        break;
                }
            }

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Paquete paquete = new Paquete(this.txtDireccion.Text, this.mtxtTrackingID.Text);
                paquete.InfomaEstado += paq_InformaEstado;
                this.correo += paquete;
                this.ActualizarEstados();
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error en el evento Agregar {ex.Message}   { ex.InnerException.Message}","ERROR",MessageBoxButtons.OK);
            }
        }
        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            this.MostrarInformacion<List<Paquete>>((IMostar<List<Paquete>>)correo);
        }

        private void MostrarInformacion<T>(IMostar<T> elemento)
        {
            if(elemento !=null)
            {
                this.rtbMostar.Text = elemento.MostrarDatos(elemento);
                this.rtbMostar.Text.Guardar("salida.txt");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

        private void FrmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.correo.FinEntregas();
        }
        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            {
                this.ActualizarEstados();
            }
        }

        private void mostrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.MostrarInformacion<Paquete>((IMostar<Paquete>)lstEstadoEntregado.SelectedItem);
        }
    }
}
