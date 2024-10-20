using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5Semana9
{
    public class GestorArreglo
    {
        // Función que invierte un arreglo de enteros.
        public int[] InvertirArreglo(int[] arreglo)
        {
            int longitud = arreglo.Length;
            int[] arregloInvertido = new int[longitud];

            for (int i = 0; i < longitud; i++)
            {
                arregloInvertido[i] = arreglo[longitud - 1 - i];
            }

            return arregloInvertido;
        }

        // Función que determina cuántos números impares hay en un arreglo.
        public void ContarImpares(int[] arreglo)
        {
            int conteoImpares = 0;

            foreach (int num in arreglo)
            {
                if (num % 2 != 0)
                {
                    conteoImpares++;
                    Console.WriteLine($"Número impar encontrado: {num}");
                }
            }

            Console.WriteLine($"Total de números impares: {conteoImpares}");
        }
    }
}