using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
          try
          {
            double rectangular, x, y, angulo;

            Console.Title = "Conviertiendo coordenadas";

            Console.WriteLine("Ingresa el valor de polar");
            rectangular = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor del angulo");
            angulo = double.Parse(Console.ReadLine());

            Console.Title = "Resultados";
            x = rectangularX(rectangular, angulo);
            Console.WriteLine($"La componente rectangular X es: {x}");

            y = rectangularY(rectangular, angulo);
            Console.WriteLine($"La componente rectangular Y es: {y}");
          }
           catch (FormatException)
           {
             Console.WriteLine("El dato ingresado no es válido");
           }

           Console.ReadKey();
        }
        static double rectangularX(double a, double b)
        {
          double compX;
          compX = Math.Round(a * Math.Cos(b), 2);
          return compX;
        }
        static double rectangularY(double a, double b)
        {
          double compY;
          compY = Math.Round(a * Math.Sin(b), 2);
          return compY;
        }
    }
}
