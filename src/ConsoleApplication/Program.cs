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
            int i;
            for (i=0;i<100;i++)
            {
                string nombre = i.ToString();
                var Train = new Train(nombre);
            }
            var t1= new Train("Last Train to London");
            var t2= new Train("Last Train to London");
            var t3= new Train("Runaway Train");
            Console.WriteLine($"{t1==t2} {t2==t3}");

            // El t1 y t2 a pesar de tener el mismo id no son el mismo objeto, por eso da negativo
            // y en el t2 y t3 tampoco son el mismo, pero este no genera lugar a dudas ya que el id es distinto

            Console.WriteLine(Train.Count); // imprime el count de los trenes creados
        }
    }
}