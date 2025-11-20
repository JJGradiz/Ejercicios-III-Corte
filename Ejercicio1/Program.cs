using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [20];
            Random rnd = new Random();

            for (int i = 0; i < numeros.Length; i++) 
            {
             numeros[i] = rnd.Next(1, 101);
             Console.Write(numeros[i] + " ");
            }

            Console.WriteLine("\n\nIngrese un número a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            int posicion = -1;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == buscado)
                {
                    posicion = i;
                    break; 
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"El número {buscado} se encontró en la posición {posicion}.");
            }
            else
            {
                Console.WriteLine($"El número {buscado} no se encontró en el arreglo.");
            }

            Console.WriteLine("Presione cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
