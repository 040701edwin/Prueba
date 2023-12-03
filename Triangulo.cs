using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Triangulo : FiguraGeometrica, IFiguraGeometrica
    {
        // Propiedades
        public double Base { get; set; }
        public double Altura { get; set; }

        // Constructor por defecto
        public Triangulo()
        {

        }

        // Constructor con parámetros
        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        // Implementación de métodos abstractos
        public override double CalcularArea()
        {
            return 0.5 * Base * Altura;
        }

        public override double CalcularPerimetro()
        {
            return 0;
        }

        // Implementación de métodos de la interfaz
        public void MostrarInformacion()
        {
            Console.WriteLine($"Triángulo - Base: {Base}, Altura: {Altura}");
            Console.WriteLine($"Área: {CalcularArea()}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un triángulo...");
        }
    }
}
