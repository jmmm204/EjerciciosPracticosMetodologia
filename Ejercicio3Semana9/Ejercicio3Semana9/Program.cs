using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Semana9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de GestorTemperaturas
            GestorTemperaturas gestor = new GestorTemperaturas();
            string opcionEntrada;
            int opcionMenu;

            // Bucle para agregar temperaturas
            do
            {
                Console.Write("Introduce una temperatura en grados Celsius: ");
                double temperaturaCelsius = double.Parse(Console.ReadLine());

                // Agregar la temperatura y convertirla
                gestor.AgregarTemperatura(temperaturaCelsius);

                Console.WriteLine("¿Deseas agregar otra temperatura? (s/n): ");
                opcionEntrada = Console.ReadLine();
            } while (opcionEntrada.ToLower() == "s");  // Repetir si el usuario elige 's'

            // Menú de opciones para operaciones adicionales
            do
            {
                Console.WriteLine("\n--- Menú de Opciones ---");
                Console.WriteLine("1. Mostrar temperaturas convertidas a Fahrenheit y Kelvin");
                Console.WriteLine("2. Eliminar una temperatura convertida");
                Console.WriteLine("3. Salir del programa");
                Console.Write("Selecciona una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        gestor.MostrarTemperaturasConvertidas();  // Mostrar las temperaturas convertidas
                        break;
                    case 2:
                        Console.Write("Introduce el número de la temperatura a eliminar (1 para la primera): ");
                        int indice = int.Parse(Console.ReadLine()) - 1;  // Convertir a índice
                        gestor.EliminarTemperaturaConvertida(indice);  // Eliminar la temperatura
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcionMenu != 3);  // Repetir hasta que el usuario elija salir
        }
    }
}