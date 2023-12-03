using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Circulo : FiguraGeometrica, IFiguraGeometrica
    {
        // Propiedad
        public double Radio { get; set; }

        // Constructor por defecto
        public Circulo()
        {

        }

        // Constructor con parámetros
        public Circulo(double radio)
        {
            Radio = radio;
        }

        // Implementación de métodos abstractos
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        // Implementación de métodos de la interfaz
        public void MostrarInformacion()
        {
            Console.WriteLine($"Círculo - Radio: {Radio}");
            Console.WriteLine($"Área: {CalcularArea()}");
            Console.WriteLine($"Circunferencia: {CalcularPerimetro()}");
        }

        public void DibujarFigura()
        {
            Console.WriteLine("Dibujando un círculo...");
        }
    }
}
