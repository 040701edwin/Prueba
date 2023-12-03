using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public abstract class FiguraGeometrica
    {
        // Métodos abstractos
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    public interface IFiguraGeometrica
    {
        // Métodos de la interfaz
        void MostrarInformacion();
        void DibujarFigura();
    }
}
