using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Coordenadas en el plano cartesiano";
            int x, y, n, f, cant1, cant2, cant3, cant4;
            String puntos;
            cant1 = 0;
            cant2 = 0;
            cant3 = 0;
            cant4 = 0;

            Console.Write("Digite la cantidad de puntos:");
            puntos = Console.ReadLine();
            n = int.Parse(puntos);
            for (f = 1; f <= n; f++)
            {
                Console.WriteLine("Ingrese coordenadas en x");
                puntos = Console.ReadLine();
                x = int.Parse(puntos);
                Console.WriteLine("ingrese coordenadas en y");
                puntos = Console.ReadLine();
                y = int.Parse(puntos);
                
                if(x>0 && y>0)
                {
                    cant1++;
                }
                else
                {
                    if(x<0 && y>0)
                    {
                        cant2++;
                    }
                    else
                    {
                        if (x < 0 && y < 0)
                        {
                            cant3++;
                        }
                        else
                        {
                            if (x > 0 && y < 0)
                            {
                                cant4++;
                            }
                        }
                    }
                }

            }
            Console.WriteLine("Cantidad de puntos en el primer cuadrante ");
            Console.WriteLine(cant1);
            Console.WriteLine("Cantidad de puntos en el segundo cuadrante ");
            Console.WriteLine(cant2);
            Console.WriteLine("Cantidad de puntos en el tercer cuadrante ");
            Console.WriteLine(cant3);
            Console.WriteLine("Cantidad de puntos en el cuarto cuadrante ");
            Console.WriteLine(cant4);
            Console.ReadKey();
        }
    }
}
