using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaFiguraGeometroca.Interface
{
    interface IFiguraGeometrica
    {
        float CalcularArea();
        float CalcularPerimetro();
        string ObtenerNombre();
    }
}
