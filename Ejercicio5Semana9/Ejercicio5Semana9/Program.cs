using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Semana9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de GestorArreglo
            GestorArreglo gestor = new GestorArreglo();

            // Definir el arreglo original de enteros
            int[] arregloOriginal = { 5, 8, 3, 7, 2, 9, 6, 4 };

            // Mostrar el arreglo original
            Console.WriteLine("Arreglo original:");
            MostrarArreglo(arregloOriginal);

            // Invertir el arreglo
            int[] arregloInvertido = gestor.InvertirArreglo(arregloOriginal);

            // Mostrar el arreglo invertido
            Console.WriteLine("\nArreglo invertido:");
            MostrarArreglo(arregloInvertido);

            // Contar e imprimir los números impares en el arreglo invertido
            Console.WriteLine("\nNúmeros impares en el arreglo invertido:");
            gestor.ContarImpares(arregloInvertido);
        }

        // Función para mostrar un arreglo
        static void MostrarArreglo(int[] arreglo)
        {
            foreach (int num in arreglo)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
        }
    }
}