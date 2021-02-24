using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tabla de multiplicar";
            int i;
            Double num, resultado;

            Console.WriteLine("Digite el numero");
            num = Double.Parse(Console.ReadLine());
            for(i=1; i<=10; i++)
            {
                resultado = num * i;
                Console.WriteLine(num +" x " + i + " = " + resultado);
            }
        }
    }
}
