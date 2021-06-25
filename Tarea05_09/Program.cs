using System;

namespace Tarea05_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int longitud = 5;
            int[] vector = new int[longitud];
            for (int i= 0; i < longitud; i++)
            {
                Console.Write("Introduce el valor de la posición {0}/{1}: ", i + 1, longitud);
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array introducido de {0} posiciones:", longitud);
            Console.Write("{ ");
            for (int i=0; i<longitud; i++)
            {
                if (i < longitud - 1)
                {
                    Console.Write(" {0},", vector[i]);
                }
                else
                {
                    Console.Write(" {0} }}", vector[i]);
                }
                
            }

            Console.ReadKey();
        }
    }
}
