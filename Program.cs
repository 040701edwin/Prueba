using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFiguraGeometrica> figuras = new List<IFiguraGeometrica>();

            while (true)
            {
                MostrarMenu();

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        CrearCuadrado(figuras);
                        break;
                    case "2":
                        CrearTriangulo(figuras);
                        break;
                    case "3":
                        CrearRectangulo(figuras);
                        break;
                    case "4":
                        CrearCirculo(figuras);
                        break;
                    case "5":
                        MostrarFiguras(figuras);
                        break;
                    case "6":
                        return; // Salir del programa
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void MostrarMenu()
        {
            Console.WriteLine("1. Crear Cuadrado");
            Console.WriteLine("2. Crear Triángulo");
            Console.WriteLine("3. Crear Rectangulo");
            Console.WriteLine("4. Crear Circulo");
            Console.WriteLine("5. Mostrar Figuras");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
        }

        static void CrearRectangulo(List<IFiguraGeometrica> figuras)
        {
            Console.Write("Ingrese el lado1 del rectángulo: ");
            if (double.TryParse(Console.ReadLine(), out double lado1))
            {
                Console.Write("Ingrese el lado2 del rectángulo: ");
                if (double.TryParse(Console.ReadLine(), out double lado2))
                {
                    figuras.Add(new Rectangulo(lado1, lado2));
                    Console.WriteLine("Rectángulo creado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Lado2 no válido. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Lado1 no válido. Intente de nuevo.");
            }
        }

        static void CrearCirculo(List<IFiguraGeometrica> figuras)
        {
            Console.Write("Ingrese el radio del círculo: ");
            if (double.TryParse(Console.ReadLine(), out double radio))
            {
                figuras.Add(new Circulo(radio));
                Console.WriteLine("Círculo creado exitosamente.");
            }
            else
            {
                Console.WriteLine("Radio no válido. Intente de nuevo.");
            }
        }

        static void CrearCuadrado(List<IFiguraGeometrica> figuras)
        {
            Console.Write("Ingrese el lado del cuadrado: ");
            if (double.TryParse(Console.ReadLine(), out double lado))
            {
                figuras.Add(new Cuadrado(lado));
                Console.WriteLine("Cuadrado creado exitosamente.");
            }
            else
            {
                Console.WriteLine("Entrada no válida. Intente de nuevo.");
            }
        }

        static void CrearTriangulo(List<IFiguraGeometrica> figuras)
        {
            Console.Write("Ingrese la base del triángulo: ");
            if (double.TryParse(Console.ReadLine(), out double @base))
            {
                Console.Write("Ingrese la altura del triángulo: ");
                if (double.TryParse(Console.ReadLine(), out double altura))
                {
                    figuras.Add(new Triangulo(@base, altura));
                    Console.WriteLine("Triángulo creado exitosamente.");
                }
                else
                {
                    Console.WriteLine("Altura no válida. Intente de nuevo.");
                }
            }
            else
            {
                Console.WriteLine("Base no válida. Intente de nuevo.");
            }
        }

        static void MostrarFiguras(List<IFiguraGeometrica> figuras)
        {
            foreach (var figura in figuras)
            {
                figura.MostrarInformacion();
                figura.DibujarFigura();
                Console.WriteLine();
            }
        }
    }
}
