using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Asteriscos del 1 al 15";
            int i = 1;
            int numero;
            try
            {
                Console.WriteLine("Digite un número entre 1 y 15");
                numero = int.Parse(Console.ReadLine());
                if (numero > 15)
                {
                    Console.Write("¿Qué paso master, no ve qué ahí dice del 1 al 15?");
                }
                else if (numero < 1)
                {
                    Console.Write("¿Qué paso master, no ve qué ahí dice del 1 al 15?");
                }
                while (i <= numero)
                {
                    Console.Write("*");
                    i++;
                }
            }
            catch (Exception error)
            {
                Console.Write(error);
            }
            Console.ReadKey();
        }
    }
}
