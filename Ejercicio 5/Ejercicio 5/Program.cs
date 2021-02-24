using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Excepto el 25";
            int i;

            for (i = 1; i <= 30; i++)
            {
                if(i == 25)
                {
                    i++;
                }
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
