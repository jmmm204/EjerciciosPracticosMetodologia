using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1Semana9
{
    // Struct que contiene los datos de una persona
    public struct Persona
    {
        public string nombre;
        public string direccion;
        public string telefono;
        public int edad;
    }

    // Clase que maneja las operaciones sobre las personas
    public class GestorPersonas
    {
        // Arreglo que almacenará las personas
        private Persona[] personas;
        private int contador;

        // Constructor
        public GestorPersonas(int tamaño)
        {
            personas = new Persona[tamaño];
            contador = 0;
        }

        // Método para agregar una persona al arreglo
        public void AgregarPersona(string nombre, string direccion, string telefono, int edad)
        {
            if (contador < personas.Length)
            {
                personas[contador] = new Persona { nombre = nombre, direccion = direccion, telefono = telefono, edad = edad };
                contador++;
            }
            else
            {
                Console.WriteLine("No se pueden agregar más personas.");
            }
        }

        // Método para mostrar todos los nombres
        public void MostrarTodosLosNombres()
        {
            Console.WriteLine("Lista de todos los nombres:");
            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine(personas[i].nombre);
            }
        }

        // Método para mostrar personas de una cierta edad
        public void MostrarPersonasPorEdad(int edad)
        {
            Console.WriteLine($"Personas de {edad} años:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].edad == edad)
                {
                    Console.WriteLine($"Nombre: {personas[i].nombre}, Dirección: {personas[i].direccion}, Teléfono: {personas[i].telefono}");
                }
            }
        }

        // Método para mostrar personas que coincidan con un nombre
        public void MostrarPersonasPorNombre(string nombre)
        {
            Console.WriteLine($"Personas con el nombre {nombre}:");
            for (int i = 0; i < contador; i++)
            {
                if (personas[i].nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Nombre: {personas[i].nombre}, Dirección: {personas[i].direccion}, Teléfono: {personas[i].telefono}, Edad: {personas[i].edad}");
                }
            }
        }
    }
}