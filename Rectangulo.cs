using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Rectangulo : FiguraGeometrica, IFiguraGeometrica
    {
        // Propiedades
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        // Constructor por defecto
        public Rectangulo()
        {

        }

        // Constructor con parámetros
        public Rectangulo(double lado1, double lado2)
        {
            Lado1 = lado1;
            Lado2 = lado2;
        }

        // Implementación de métodos abstractos
        public override double CalcularArea()
        {
            return Lado1 * Lado2;
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Lado1 + Lado2);
        }

        // Implementación de métodos de la interfaz
        public void MostrarInformacion()
        {
            Console.WriteLine($"Rectángulo - Lado1: {Lado1}, Lado2: {Lado2}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un rectángulo...");
        }
    }
}

