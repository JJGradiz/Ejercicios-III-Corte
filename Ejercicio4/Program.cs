using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

class Estudiante
{
    public int Id { get; set; }
    public string Nombre { get; set; }
}

class Program
{
    static void Main()
    {

        List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante{Id = 1, Nombre = "Ana"},
            new Estudiante{Id = 2, Nombre = "Luis"},
            new Estudiante{Id = 3, Nombre = "María"},
            new Estudiante{Id = 4, Nombre = "Carlos"},
            new Estudiante{Id = 5, Nombre = "Pedro"},
            new Estudiante{Id = 6, Nombre = "Sofía"},
            new Estudiante{Id = 7, Nombre = "Andrés"},
            new Estudiante{Id = 8, Nombre = "Valeria"},
            new Estudiante{Id = 9, Nombre = "Josué"},
            new Estudiante{Id = 10, Nombre = "Elena"}
        };

        Console.WriteLine("--- Búsqueda de Estudiantes ---");


        Console.Write("\nIngrese un ID a buscar (búsqueda lineal): ");
        int idBuscado = int.Parse(Console.ReadLine());

        Estudiante estId = BuscarPorIdLineal(estudiantes, idBuscado);

        if (estId != null)
            Console.WriteLine($" Encontrado: {estId.Id} - {estId.Nombre}");
        else
            Console.WriteLine(" No se encontró un estudiante con ese ID.");




        estudiantes.Sort((a, b) => a.Nombre.CompareTo(b.Nombre));

        Console.Write("\nIngrese un nombre a buscar (búsqueda binaria): ");
        string nombreBuscado = Console.ReadLine();

        Estudiante estNom = BuscarPorNombreBinaria(estudiantes, nombreBuscado);

        if (estNom != null)
            Console.WriteLine($" Encontrado: {estNom.Id} - {estNom.Nombre}");
        else
            Console.WriteLine(" No existe un estudiante con ese nombre.");

        Console.WriteLine("\nPresione una tecla para salir...");
        Console.ReadKey();
    }


    static Estudiante BuscarPorIdLineal(List<Estudiante> lista, int id)
    {
        foreach (var est in lista)
        {
            if (est.Id == id)
                return est;
        }
        return null;
    }


    static Estudiante BuscarPorNombreBinaria(List<Estudiante> lista, string nombre)
    {
        nombre = nombre.ToLower();

        int low = 0;
        int high = lista.Count - 1;

        while (low <= high)
        {
            int mid = (low + high) / 2;
            string nombreMid = lista[mid].Nombre.ToLower();

            int comparacion = string.Compare(nombreMid, nombre);

            if (comparacion == 0)
            {
                return lista[mid];
            }
            else if (comparacion < 0)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return null;
    }
}
