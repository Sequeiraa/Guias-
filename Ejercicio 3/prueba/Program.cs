using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1, lado2, lado3, f, n, cantidad1, cantidad2, cantidad3;
            String linea;
            cantidad1 = 0;
            cantidad2 = 0;
            cantidad3 = 0;

            Console.Write("Ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for(f=1; f<=n; f++)
            {
                Console.Write("Ingrese el lado 1: ");
                linea = Console.ReadLine();
                lado1 = int.Parse(linea);
                Console.Write("Ingrese el lado 2: ");
                linea = Console.ReadLine();
                lado2 = int.Parse(linea);
                Console.Write("Ingrese el lado 3: ");
                linea = Console.ReadLine();
                lado3 = int.Parse(linea);
                
                if(lado1 == lado2 && lado1 == lado3)
                {
                    cantidad1++;
                }
                else
                {
                    if(lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        cantidad2++;
                    }
                    else
                    {
                        cantidad3++;
                    }
                } 
            }
            Console.Write("Cantidad de triangulos equilateros: ");
            Console.WriteLine(cantidad1);
            Console.Write("Cantidad de triangulos isoceles: ");
            Console.WriteLine(cantidad2);
            Console.Write("Cantidad de triangulos escalenos: ");
            Console.WriteLine(cantidad3);

            if (cantidad1 < cantidad2 && cantidad1 < cantidad3)
            {
                Console.Write("Hay menor cantidad de triangulos equilateros");
            }
            else
            {
                if (cantidad2 < cantidad3)
                {
                    Console.Write("Hay menor cantidad de triangulos isósceles");
                }
                else
                {
                    Console.Write("Hay menor cantidad de triangulos escalenos");
                }
            }
            Console.ReadKey();
        }  
    }
}
