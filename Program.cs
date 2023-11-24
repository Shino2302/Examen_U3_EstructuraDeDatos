using System;

namespace Examen_Sigfrido_Encinas
{
   public class Program
    {
        static void Main(string[] args)
        { 
            Lista lista = new Lista();
            for (int i = 0; i < 3; i++) 
            {
                Console.Clear();
                Console.WriteLine($"Ingresa el nombre de la {i + 1}a persona");
                string nombre = Console.ReadLine();
                Console.WriteLine($"Ingresa la edad de la {i + 1}a persona");
                int edad = int.Parse(Console.ReadLine());
                lista.AgregarEnLista(nombre, edad);
            }
            Console.WriteLine("Ingresa un nombre a buscar en tu lista: "); ;
            lista.BuscarPorNombre(Console.ReadLine());
            lista.ListarOrdenadoPorEdad();
        }
    }
}