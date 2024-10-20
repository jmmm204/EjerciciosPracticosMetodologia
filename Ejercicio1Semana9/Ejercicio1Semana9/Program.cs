using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Semana9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorPersonas gestor = new GestorPersonas(10);  // Tamaño máximo de 10 personas
            string opcionEntrada;
            int opcionMenu;

            // Bucle para agregar personas
            do
            {
                Console.WriteLine("Introduce los datos de una persona:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Dirección: ");
                string direccion = Console.ReadLine();
                Console.Write("Teléfono: ");
                string telefono = Console.ReadLine();
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                // Agregar persona al arreglo
                gestor.AgregarPersona(nombre, direccion, telefono, edad);

                Console.WriteLine("¿Deseas agregar otra persona? (s/n): ");
                opcionEntrada = Console.ReadLine();
            } while (opcionEntrada.ToLower() == "s");

            // Menú de opciones
            do
            {
                Console.WriteLine("\n--- Menú de Opciones ---");
                Console.WriteLine("1. Mostrar la lista de todos los nombres");
                Console.WriteLine("2. Mostrar personas de una cierta edad");
                Console.WriteLine("3. Mostrar personas que coincidan con un nombre");
                Console.WriteLine("4. Salir del programa");
                Console.Write("Selecciona una opción: ");
                opcionMenu = int.Parse(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        gestor.MostrarTodosLosNombres();
                        break;
                    case 2:
                        Console.Write("Introduce la edad a buscar: ");
                        int edadBusqueda = int.Parse(Console.ReadLine());
                        gestor.MostrarPersonasPorEdad(edadBusqueda);
                        break;
                    case 3:
                        Console.Write("Introduce el nombre a buscar: ");
                        string nombreBusqueda = Console.ReadLine();
                        gestor.MostrarPersonasPorNombre(nombreBusqueda);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (opcionMenu != 4);
        }
    }
}