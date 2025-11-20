using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 10, 25, -3, 50, 7, 
            90, 12, 1, 44, 8 };

            Console.WriteLine("Lista de números:");
            Console.WriteLine(string.Join(", ", numeros));

            int maximo, minimo, iteraciones;

            BuscarMaxMin(numeros, out maximo, out minimo, out iteraciones);

            Console.WriteLine($"\nValor máximo: {maximo}");
            Console.WriteLine($"Valor mínimo: {minimo}");
            Console.WriteLine($"Iteraciones realizadas: {iteraciones}");

            Console.WriteLine("\nPresione una tecla para salir...");
            Console.ReadKey();
        }

        
        static void BuscarMaxMin(List<int> lista, 
        out int max, out int min, out int iter)
        {
            
            max = lista[0];
            min = lista[0];
            iter = 0;

            
            for (int i = 1; i < lista.Count; i++)
            {
                iter++; 

                if (lista[i] > max)
                    max = lista[i];

                if (lista[i] < min)
                    min = lista[i];
            }








        }
    }
}
