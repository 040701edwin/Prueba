using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Cuadrado : FiguraGeometrica, IFiguraGeometrica
    {
        // Propiedades
        public double Lado { get; set; }

        // Constructor por defecto
        public Cuadrado()
        {

        }

        // Constructor con parámetros
        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        // Implementación de métodos abstractos
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado;
        }

        // Implementación de métodos de la interfaz
        public void MostrarInformacion()
        {
            Console.WriteLine($"Cuadrado - Lado: {Lado}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Perímetro: {CalcularPerimetro()}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un cuadrado...");
        }
    }
}

