using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un párrafo:");
            string parrafo = Console.ReadLine();

            Console.WriteLine("Ingrese la palabra a buscar:");
            string palabra = Console.ReadLine();

            int cantidad = ContarOcurrencias(parrafo, palabra);

            Console.WriteLine($"\nLa palabra \"{palabra}\" aparece {cantidad} veces.");
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }


        static int ContarOcurrencias(string texto, string palabra)
        {

            texto = texto.ToLower();
            palabra = palabra.ToLower();

            int contador = 0;


            for (int i = 0; i <= texto.Length - palabra.Length; i++)
            {
                bool coincide = true;


                for (int j = 0; j < palabra.Length; j++)
                {
                    if (texto[i + j] != palabra[j])
                    {
                        coincide = false;
                        break;
                    }
                }

                if (coincide)
                    contador++;
            }

            return contador;
        }
    }
}
