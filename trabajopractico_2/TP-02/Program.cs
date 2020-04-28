using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
namespace TP_02_2018
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region CONFIGURACION PANTALLA
            // Configuración de la pantalla
            Console.SetWindowPosition(0, 0);
            Console.SetWindowSize(Console.LargestWindowWidth / 2, Console.LargestWindowHeight - 2); 
            #endregion

            #region INICIALIZO

            // Nombre del alumno
            Console.Title = "";
            Estacionamiento estacionamiento = new Estacionamiento(6);

            Moto c1 = new Moto(Vehiculo.EMarca.BMW, "ASD012", ConsoleColor.Black);
            Moto c2 = new Moto(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Red);
            Automovil m1 = new Automovil(Vehiculo.EMarca.Toyota, "HJK789", ConsoleColor.White);
            Automovil m2 = new Automovil(Vehiculo.EMarca.Chevrolet, "IOP852", ConsoleColor.Blue, Automovil.ETipo.Sedan);
            Camioneta a1 = new Camioneta(Vehiculo.EMarca.Ford, "QWE968", ConsoleColor.Gray);
            Camioneta a2 = new Camioneta(Vehiculo.EMarca.Renault, "TYU426", ConsoleColor.DarkBlue);
            Camioneta a3 = new Camioneta(Vehiculo.EMarca.BMW, "IOP852", ConsoleColor.Green);
            Camioneta a4 = new Camioneta(Vehiculo.EMarca.BMW, "TRE321", ConsoleColor.Green);
            #endregion

            #region AGREGO

            // Agrego 8 ítems (los últimos 2 no deberían poder agregarse ni el m1 repetido) y muestro
            estacionamiento += c1;
            estacionamiento += c2;
            estacionamiento += m1;
            estacionamiento += m1;
            estacionamiento += m2;
            estacionamiento += a1;
            estacionamiento += a2;
            estacionamiento += a3;
            estacionamiento += a4;
            #endregion

            #region MOSTRAR TODOS
            Console.WriteLine(estacionamiento.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();

            #endregion

            #region QUITAR

            // Quito 2 items y muestro
            estacionamiento -= c1;
            estacionamiento -= (new Moto(Vehiculo.EMarca.Honda, "ASD913", ConsoleColor.Red));
            #endregion

            #region MOSTRAR TODO 
            Console.WriteLine(estacionamiento.ToString());
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region AGREGO
            // Vuelvo a agregar c2
            estacionamiento += c2; 
            #endregion

            #region SOLO MOTOS

            //Muestro solo Moto
            Console.WriteLine(estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Moto));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR-----------> ");
            Console.Beep();
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region SOLO AUTOS

            // Muestro solo Automovil
            Console.WriteLine(estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Automovil));
            Console.WriteLine("<-----------PRESIONE UNA TECLA PARA CONTINUAR----------->");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region SOLO CAMIONETAS

            // Muestro solo Camioneta
            Console.WriteLine(estacionamiento.Mostrar(estacionamiento, Estacionamiento.ETipo.Camioneta));
            Console.WriteLine("<-------------PRESIONE UNA TECLA PARA SALIR------------->");
            Console.ReadKey(); 
            #endregion
        }
    }
}
