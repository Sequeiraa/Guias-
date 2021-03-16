using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Calculadora de edad";
            fechaNacimiento();
            Console.ReadKey();
            Console.Clear();    
        }
        static void fechaNacimiento()
        {
            int añoNacimiento, añoActual, años;
            Console.WriteLine("Digite su fecha de nacimiento");
            añoNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el año en el que estamos");
            añoActual = int.Parse(Console.ReadLine());
            años = añoActual - añoNacimiento;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"\nTu edad es de {años} años", años);

            Console.ReadKey();
        }
    }
}
