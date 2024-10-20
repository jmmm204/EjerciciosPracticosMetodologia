using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3GuiaDidacticaSemana9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorEstudiantes gestor = new GestorEstudiantes();
            string opcion;

            do
            {
                Console.Write("Introduce el nombre del estudiante: ");
                string nombre = Console.ReadLine();

                List<double> calificaciones = new List<double>();
                string continuar;
                do
                {
                    Console.Write($"Introduce una calificación para {nombre}: ");
                    double calificacion = double.Parse(Console.ReadLine());
                    calificaciones.Add(calificacion);

                    Console.Write("¿Deseas agregar otra calificación? (s/n): ");
                    continuar = Console.ReadLine();
                } while (continuar.ToLower() == "s");

                gestor.AgregarEstudiante(nombre, calificaciones);

                Console.Write("¿Deseas agregar otro estudiante? (s/n): ");
                opcion = Console.ReadLine();
            } while (opcion.ToLower() == "s");

            gestor.DeterminarAltoBajoEstudiante();
        }
    }
}
