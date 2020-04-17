using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        
        public FormCalculadora()
        {
            
            InitializeComponent();
          //  Dispose();
        }

       

        private static string Operar(string numUno , string numDos, string operacion)
        {
            Numero NumeroUno = new Numero(numUno);
            Numero NumeroDos = new Numero(numDos);
            double resultado = Calculadora.Operar(NumeroUno, NumeroDos, operacion);
            return resultado.ToString();

        }

        private void BtnOperar_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Operar(TxtNumero1.Text, TxtNumero2.Text, CmbOperador.Text);

        }
        private  void Limpiar()
        {
            CmbOperador.ResetText();
            TxtNumero1.Clear();
            TxtNumero2.Clear();
            TxtResultado.ResetText();


        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta seguro que desea cerrar?",
                "Cerrar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();
            }
             
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BtnConvertiraBinario_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Numero.DecimialBinario(TxtResultado.Text);
        }

        private void BtnConvertirADecimal_Click(object sender, EventArgs e)
        {
            TxtResultado.Text = Numero.BinarioDecimal(TxtResultado.Text);
        }
    }
}
