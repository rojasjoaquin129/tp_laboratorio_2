using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;


namespace trabajopractico_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero num1= new Numero(101);
            Numero num2 = new Numero(1);
           double resultado= Calculadora.Operar(num1, num2, "/");
           //Console.WriteLine("ivan el resultado es "+resultado);
           //Console.WriteLine(Numero.DecimialBinario(resultado.ToString()));
           Console.ReadKey();

        }
    }
}
