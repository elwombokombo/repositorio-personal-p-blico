//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            int contador=0;
            while (contador<100)//Al cambiar de 100 a 10000000 la consola demora mucho trabajando
            {
                var train = new Train("Tomas");
                train.StartEngines();
                Console.WriteLine("Hello World!");
                contador ++;
            }
            //Console.WriteLine($"El valor en el contador de la clase Train es de {Train.getCount()}");
            //No fui capaz de corregir el error cuando intento conseguir el número del contador, mi intento fue la línea de arriba.
            Train t1=new Train("Last train to London");
            Train t2=new Train("Last train to London");
            Train t3=new Train("Runaway train");
            //t1==t2;
            //t2==t3;
            //Los dos comandos de arriba por sí solos dan un error, imagino es porque al ser una comparación y no estar dentro de un if, while, entre otros. No funcionan.
        }
    }
}