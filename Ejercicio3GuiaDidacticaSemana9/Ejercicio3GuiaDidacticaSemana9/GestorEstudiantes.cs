using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3GuiaDidacticaSemana9
{
    public class GestorEstudiantes
    {
        private List<Estudiante> estudiantes;

        public GestorEstudiantes()
        {
            estudiantes = new List<Estudiante>();
        }

        // Función para agregar un estudiante y sus calificaciones
        public void AgregarEstudiante(string nombre, List<double> calificaciones)
        {
            Estudiante estudiante = new Estudiante
            {
                Nombre = nombre,
                Calificaciones = calificaciones,
                Promedio = CalcularPromedio(calificaciones)
            };
            estudiantes.Add(estudiante);
        }

        // Función para calcular el promedio de un estudiante
        public double CalcularPromedio(List<double> calificaciones)
        {
            double suma = 0;
            foreach (double calificacion in calificaciones)
            {
                suma += calificacion;
            }
            return suma / calificaciones.Count;
        }

        // Función para determinar el estudiante con el promedio más alto y más bajo
        public void DeterminarAltoBajoEstudiante()
        {
            if (estudiantes.Count == 0)
            {
                Console.WriteLine("No hay estudiantes registrados.");
                return;
            }

            Estudiante estudianteMayor = estudiantes[0];
            Estudiante estudianteMenor = estudiantes[0];

            foreach (Estudiante estudiante in estudiantes)
            {
                if (estudiante.Promedio > estudianteMayor.Promedio)
                {
                    estudianteMayor = estudiante;
                }

                if (estudiante.Promedio < estudianteMenor.Promedio)
                {
                    estudianteMenor = estudiante;
                }
            }

            Console.WriteLine($"El estudiante con el promedio más alto es {estudianteMayor.Nombre} con un promedio de {estudianteMayor.Promedio:F2}");
            Console.WriteLine($"El estudiante con el promedio más bajo es {estudianteMenor.Nombre} con un promedio de {estudianteMenor.Promedio:F2}");
        }
    }

    // Definición de la estructura para almacenar la información de los estudiantes
    public struct Estudiante
    {
        public string Nombre { get; set; }
        public List<double> Calificaciones { get; set; }
        public double Promedio { get; set; }
    }
}