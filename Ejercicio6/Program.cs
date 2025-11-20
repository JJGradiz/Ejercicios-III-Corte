using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main()
        {
            const int filas = 10;
            const int columnas = 10;

            int[,] matriz = new int[filas, columnas];
            Random rnd = new Random();

            
            Console.WriteLine("Matriz generada:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    matriz[i, j] = rnd.Next(1, 101); 
                    Console.Write(matriz[i, j].ToString("D3") + " ");
                }
                Console.WriteLine();
            }

            Console.Write("Ingrese el número a buscar: ");
            int buscado = int.Parse(Console.ReadLine());

            bool encontrado = false;

            Console.WriteLine("Buscando en toda la matriz");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] == buscado)
                    {
                        encontrado = true;
                        Console.WriteLine($" Encontrado en posición: fila {i}, columna {j}");
                    }
                }
            }

            if (!encontrado)
            {
                Console.WriteLine($" El número {buscado} no aparece en la matriz.");
            }

            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();




















        }






        
    }
}
