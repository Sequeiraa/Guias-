using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Pares";
                double num1, num2, i;

                Console.WriteLine("Ingrese el primer número ");
                num1 = double.Parse(Console.ReadLine());

                while (num1 < 0)
                {
                    Console.WriteLine("Solo trabajar con números positivos\n");
                    Console.WriteLine("Ingrese el primer número ");
                    num1 = double.Parse(Console.ReadLine());
                }
                    Console.WriteLine("Digitar el segundo número");
                    num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Los pares del primero al segundo son: ");
                for (i = num1 + 1; i < num2; i++) 
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i}");
                    }
                }

            }
            catch (Exception error)
            {
                Console.Write(error);
            }
        }
    }
}
