using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
             string menu;
            try
            {
                do
                {
                    Console.Title = "Menú";
                    Console.Write("Menu\n");

                    Console.Write("A) Dividir\t");
                    Console.Write("B) Obtener cubo\t\t");
                    Console.Write("C) Calculo de IMC\t");
                    Console.Write("D) Salir\n\n");
                    Console.WriteLine("Selecciona una opcion");
                    menu = Console.ReadLine().ToLower();

                    Console.Clear();

                    switch (menu)
                    {
                        case "a":
                            Console.Title = "Dividir dos numeros";

                            double numeroUno, numeroDos;
                            Console.WriteLine("Bienvenido a la función a la opcion dividir\n");

                            Console.WriteLine("Digite el primer valor");
                            numeroUno = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digite el segundo valor");
                            numeroDos = double.Parse(Console.ReadLine());

                            dividir(numeroUno, numeroDos);
                            Console.WriteLine("Presiona cualquier tecla para volver al menu");
                            Console.ReadKey();
                            Console.Clear();

                            break;

                        case "b":
                            Console.Title = "Cubo de un numero";

                            double numeroCubo;
                            Console.WriteLine("Bienvenido a la función a la opcion obtener cubo\n");

                            Console.WriteLine("Digita el número que quiere elevar al cubo");
                            numeroCubo = double.Parse(Console.ReadLine());
                            cubo(numeroCubo);
                            Console.WriteLine("Presiona cualquier tecla para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "c":
                            Console.Title = "Calculo de IMC";

                            double pesoPersona, alturaPersona;
                            Console.WriteLine("Bienvenido al cálculo de IMC\n");

                            Console.WriteLine("Digita tu peso en kilogramos");
                            pesoPersona = double.Parse(Console.ReadLine());

                            Console.WriteLine("Digita tu altura en metros");
                            alturaPersona = double.Parse(Console.ReadLine());
                            IMC(pesoPersona, alturaPersona);
                            Console.WriteLine("Presiona cualquier tecla para volver al menu");
                            Console.ReadKey();
                            Console.Clear();
                            break;

                        case "d":
                            Console.Title = "Salida";

                            Console.WriteLine("¡Gracias por usar el programa!");
                            Console.WriteLine("Presione cualquier tecla para salir");
                            break;

                        default:
                            Console.Title = "¿tas bien?";

                            Console.WriteLine("El valor no corresponde a ninguna opción");
                            Console.WriteLine("Presiona cualquier tecla para continuar");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                    }
                } while (menu != "d");
            }
            catch(Exception)
            {
                Console.Write("Dato invalido");
            }
            Console.ReadKey();
        }
        static void dividir(double numero1, double numero2)
        {
            double formula;
            formula = Math.Round((numero1 / numero2), 2);
            Console.WriteLine($"El resultado de dividir {numero1} entre {numero2} es: {formula}");
        }
        static void cubo(double numero)
        {
            double formula;
            formula = Math.Round(Math.Pow(numero,3));
            Console.WriteLine($"El cubo del numero {numero} es {formula}");
        }
        static void IMC(double peso, double altura)
        {
            double formula;
            formula = Math.Round(peso / (Math.Pow(altura, 2)), 2);
            Console.WriteLine($"El IMC es de {formula}");
        }
    }
}
