using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 30;
            int[] lista = new int[size];
            Random rnd = new Random();


            for (int i = 0; i < size; i++)
                lista[i] = rnd.Next(1, 201);

            Console.WriteLine("Lista generada (sin ordenar):");
            Console.WriteLine(string.Join(" ", lista));
            Console.WriteLine();


            Array.Sort(lista);
            Console.WriteLine("Lista ordenada:");
            Console.WriteLine(string.Join(" ", lista));
            Console.WriteLine();


            Console.Write("Ingrese el número a buscar: ");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out int objetivo))
            {
                Console.WriteLine("Entrada inválida. Fin del programa.");
                return;
            }


            int bajo = 0;
            int alto = lista.Length - 1;
            int paso = 0;
            bool encontrado = false;
            int posicion = -1;

            Console.WriteLine("\n--- Inicio búsqueda binaria ---\n");

            while (bajo <= alto)
            {
                paso++;
                int medio = (bajo + alto) / 2;


                Console.WriteLine($"Paso {paso}: low = {bajo}, high = {alto}, mid = {medio}, valorEnMid = {lista[medio]}");


                for (int i = bajo; i <= alto; i++)
                {
                    if (i == medio)
                        Console.Write($"[{lista[i]}] ");
                    else
                        Console.Write(lista[i] + " ");
                }
                Console.WriteLine("\n");


                if (lista[medio] == objetivo)
                {
                    encontrado = true;
                    posicion = medio;
                    Console.WriteLine($" Número {objetivo} encontrado en la posición (índice) {medio}.");
                    break;
                }
                else if (lista[medio] < objetivo)
                {
                    Console.WriteLine($"  {lista[medio]} < {objetivo}  => buscar en la mitad derecha (low = mid + 1)\n");
                    bajo = medio + 1;
                }
                else
                {
                    Console.WriteLine($"  {lista[medio]} > {objetivo}  => buscar en la mitad izquierda (high = mid - 1)\n");
                    alto = medio - 1;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($"✗ El número {objetivo} NO se encontró en la lista.");
            }

            Console.WriteLine("\n--- Fin búsqueda binaria ---");
            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }
    }
}

