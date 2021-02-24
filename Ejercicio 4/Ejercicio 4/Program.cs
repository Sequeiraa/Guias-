using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "10 números";
            int valor, positivos, negativos, i, sumaPares, multiplos15;
            String entrada;
            positivos = 0;
            negativos = 0;
            sumaPares = 0;
            multiplos15 = 0;

            for(i = 1; i<=10; i++)
            {
                Console.Write("Ingrese un valor");
                entrada = Console.ReadLine();
                valor = int.Parse(entrada);
                if(valor > 0)
                {
                    positivos++;
                }
                else if(valor < 0)
                {
                    negativos++;
                }
                if(valor%15 == 0)
                {
                    multiplos15++;
                }
                if(valor%2 == 0)
                {
                    sumaPares = sumaPares + valor;
                }
            }
            Console.Write("Cantidad de valores negativos: ");
            Console.WriteLine(negativos);
            Console.Write("Cantidad de valores positivos: ");
            Console.WriteLine(positivos);
            Console.Write("Cantidad de valores multiplos de 15: ");
            Console.WriteLine(multiplos15);
            Console.Write("El valor acumulado de los números ingresados es: ");
            Console.WriteLine(sumaPares);
            Console.ReadKey();
        }
    }
}
