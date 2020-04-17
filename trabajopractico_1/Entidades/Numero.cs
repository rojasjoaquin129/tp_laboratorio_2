using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
     public class Numero
     {
        private double numero ;


        // METODOS
        public Numero()
        {
            this.numero = 0;
        }
        public Numero (string numero)
        {
            this.SetNumeros = numero;

        }
        
        public Numero(double numero) : this(numero.ToString()){ }
        public  string SetNumeros
        {
            get
            {
                return numero.ToString();
            }    
            set
            {
               numero = ValidarNumerico(value);
            }
            
        }
       private double  ValidarNumerico (string  strNumero)
        {
            if (double.TryParse(strNumero,out double doubleNumero ))
            {
                return doubleNumero;
            }
            return 0;
        }

        // COMVERCIONES
        public static string  BinarioDecimal(string binario) 
        {
            int flag = 0;
            int decimales=0;
            string retorno = "Valor inválido";
            int y = 0;
            for (int i =0; i < binario.Length; i++)
            {
                if(binario[i] != '1' &&  binario[i] != '0')
                {
                    //medio chancho
                    flag = 1;
                    break;
                }
            }
            if (flag!=1)
            {
                for (int i = binario.Length - 1; i >= 0; i--)
                {
                    if (binario[i] == '1' )
                    {
                        decimales += (int)Math.Pow(2, y);
                       
                    }
                    y++;
                }
               retorno =decimales.ToString();
            }


            return retorno; 
        }
        public static string DecimialBinario(double numeroDouble)
        {
            int numero = Convert.ToInt32(numeroDouble);
            string retorno = "Valor inválido";
            string binario = string.Empty;
            while (numero > 0)
            {
                binario = numero % 2 + binario;
                numero /= 2;
            }
            if (binario != "") 
            {
                retorno = binario;
            }
            return retorno;
            
           
        }

        public static string DecimialBinario(string numero)
        {
            string retorno = "Valor inválido";
            if (double.TryParse(numero ,out double valor))
            {
                retorno = DecimialBinario(valor);
            }

            return retorno;
        }
        public static double operator - (Numero num1 , Numero num2)
        {
            return num1.numero - num2.numero;
        }
        public static double operator * (Numero num1, Numero num2)
        {
            return num1.numero * num2.numero;
        }
        public static double operator / (Numero num1, Numero num2)
        {
            if (num2.numero == 0)
            {
                return double.MinValue;
            }
            return num1.numero / num2.numero;
        }
        public static double operator +(Numero num1, Numero num2)
        {
            return num1.numero + num2.numero;
        }


    }
}
