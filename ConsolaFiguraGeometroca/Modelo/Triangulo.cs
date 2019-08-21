using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolaFiguraGeometroca.Interface;

namespace ConsolaFiguraGeometroca.Modelo
{
    class Triangulo : IFiguraGeometrica
    {
        private float _base;
        private float _altura;
        private const string Nombre = "Triangulo";

        public Triangulo(float b, float altura)
        {
            _base = b;
            _altura = altura;
        }

        public float CalcularArea()
        {
            return _base * _altura / 2;
        }

        public float CalcularPerimetro()
        {
            return _base * 3;
        }

        public string ObtenerNombre()
        {
            return Nombre;
        }
    }
}
