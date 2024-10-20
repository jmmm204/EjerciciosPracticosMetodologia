using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3Semana9
{
    // Clase que gestiona la conversión y manejo de temperaturas.
    public class GestorTemperaturas
    {
        // Listas genéricas para almacenar temperaturas
        private List<double> temperaturasCelsius;
        private List<double> temperaturasFahrenheit;
        private List<double> temperaturasKelvin;

        // Constructor que inicializa las listas de temperaturas.
        public GestorTemperaturas()
        {
            temperaturasCelsius = new List<double>();
            temperaturasFahrenheit = new List<double>();
            temperaturasKelvin = new List<double>();
        }

        // Agrega una temperatura en Celsius y la convierte a Fahrenheit y Kelvin.
        public void AgregarTemperatura(double temperaturaCelsius)
        {
            temperaturasCelsius.Add(temperaturaCelsius);
            temperaturasFahrenheit.Add(ConvertirAFahrenheit(temperaturaCelsius));
            temperaturasKelvin.Add(ConvertirAKelvin(temperaturaCelsius));
        }

        // Convierte una temperatura de Celsius a Fahrenheit.
        private double ConvertirAFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        // Convierte una temperatura de Celsius a Kelvin.
        private double ConvertirAKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        // Muestra las listas de temperaturas convertidas en Fahrenheit y Kelvin.
        public void MostrarTemperaturasConvertidas()
        {
            Console.WriteLine("\n--- Temperaturas en Fahrenheit ---");
            for (int i = 0; i < temperaturasFahrenheit.Count; i++)
            {
                Console.WriteLine($"Temperatura {i + 1}: {temperaturasFahrenheit[i]} °F");
            }

            Console.WriteLine("\n--- Temperaturas en Kelvin ---");
            for (int i = 0; i < temperaturasKelvin.Count; i++)
            {
                Console.WriteLine($"Temperatura {i + 1}: {temperaturasKelvin[i]} K");
            }
        }

        // Elimina una temperatura de las listas de convertidas en Fahrenheit y Kelvin.
        public void EliminarTemperaturaConvertida(int indice)
        {
            if (indice >= 0 && indice < temperaturasFahrenheit.Count)
            {
                Console.WriteLine($"Eliminando la temperatura {indice + 1}.");
                temperaturasFahrenheit.RemoveAt(indice);
                temperaturasKelvin.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Índice no válido. No se puede eliminar la temperatura.");
            }
        }
    }
}