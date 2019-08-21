using ConsolaFiguraGeometroca.Interface;
using ConsolaFiguraGeometroca.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaFiguraGeometroca
{
    class Program
    {
        static void Main(string[] args)
        {
            var cuadrado = new Cuadrado(5);
            mostrarInformacion(cuadrado);
            Console.ReadKey();
        }

        static void mostrarInformacion(IFiguraGeometrica figura)
        {
            Console.WriteLine($"Nombre: {figura.ObtenerNombre()}");
            Console.WriteLine($"Area: {figura.CalcularArea()}");
            Console.WriteLine($"Perimetro: {figura.CalcularPerimetro()}");
        }
    }
}
