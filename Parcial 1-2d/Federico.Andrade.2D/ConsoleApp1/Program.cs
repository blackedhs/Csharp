using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ConsoleApp1
{
  class Program
  {
    static void Main(string[] args)
    {
            ConsoleColor aux = Console.ForegroundColor;
            Maquina m = new Maquina("LAB01PC03");
            // Agrega
            Console.WriteLine(m + new PlacaVideo("ASUS", "P360-A", 64));
            // Agrega
            Console.WriteLine(m + new Teclado("GENIUS", "J961-P", Econector.PS2,
            Teclado.EDistribucion.AZERTY));
            // Agrega
            Console.WriteLine(m + new Teclado("GENIUS", "JRR-10", Econector.USB));
            // No agrega por cantidad superada
            Console.WriteLine(m + new PlacaVideo("SENTEY", "P361-A", 32));
            // Cambio Max Perisfericos y agrego
            m.CantidadMaxPerifericos = 5;
            Console.WriteLine(m + new PlacaVideo("SENTEY", "P361-A", 32));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Cantidad Máxima Perisfericos: " + m.CantidadMaxPerifericos);
            Console.ForegroundColor = aux;
            // Quito una
            Console.WriteLine(m - new PlacaVideo("ASUS", "P360-A", 64));
            // No agrega por repetida
            Console.WriteLine(m + new Teclado("GENIUS", "J961-P", Econector.PS2,
            Teclado.EDistribucion.AZERTY));
            // Agrega
            Console.WriteLine(m + new PlacaVideo("ASUS", "P360-A", 64));
            Console.WriteLine("\n------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(new PlacaVideo("ASUS", "P360-A", 64).ExponerDatos());
            Console.WriteLine(new Teclado("GENIUS", "JRR-10", Econector.USB).ExponerDatos());
            Console.ForegroundColor = aux;
            Console.WriteLine("\n------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(m.SystemInfo);
            Console.ForegroundColor = aux;
            Console.ReadKey();
        }
  }
}
