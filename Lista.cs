using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Sigfrido_Encinas
{
    public class Lista
    {
        private Nodo _primero;
        private Nodo _ultimo;

        public Lista()
        {
            _primero = null;
            _ultimo = null;
        }
        public bool ListaVacia()
        {
            return _primero == null ? true : false;
        }
        public bool AgregarEnLista(string nombre, int edad)
        {
            try
            {
                Nodo Nuevo = new Nodo();
                Nuevo.Persona.Nombre = nombre;
                Nuevo.Persona.Edad = edad;
                if (ListaVacia())
                {
                    _primero = Nuevo;
                    _ultimo = Nuevo;
                    Console.WriteLine($"{nombre} agregado");
                    return true;
                }
                else
                {
                    _ultimo.Siguiente = Nuevo;
                    _ultimo = Nuevo;
                    Console.WriteLine($"{nombre} agregado");
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public void BuscarPorNombre(string nombreBuscado)
        {
            if(ListaVacia())
                Console.WriteLine("La Lista se encuentra vacia");
            else
            {
                Nodo Actual = _primero;
                int posicion = -1;
                while(Actual.Siguiente != null)
                {
                    if(Actual.Persona.Nombre == nombreBuscado)
                    {
                        Console.WriteLine($"La persona '{nombreBuscado}' se encuentra en la posicion {posicion+1}");
                        break;
                    }
                    else
                    {
                        posicion++;
                        Actual = Actual.Siguiente;
                    }
                }
                if(Actual.Siguiente == null && Actual.Persona.Nombre != nombreBuscado)
                    Console.WriteLine($"El {nombreBuscado} buscado no se encuentra en la lista");
                else if(Actual.Persona.Nombre == nombreBuscado)
                {
                        Console.WriteLine($"La persona '{nombreBuscado}' se encuentra en la posicion {posicion+1}");
                }
            }
        }
        public int CantidadDeElementosEnLista()
        {
            if (ListaVacia())
            {
                return -1;
            }
            else
            {
                Nodo Actual = _primero;
                int posicion = 0;
                while(Actual.Siguiente != null)
                {
                    posicion++;
                    Actual = Actual.Siguiente;
                }
                return ++posicion;
            }
        }
        public void ListarOrdenadoPorEdad()
        {
            Console.Clear();
            if (ListaVacia())
                Console.WriteLine("La lista se encuentra vacia!");
            else
            {
                Nodo Actual = _primero;
                Nodo Auxiliar;
                int menorEnLista = Actual.Persona.Edad;
                int mayorEnLista = Actual.Persona.Edad;
                int cantidadEnLista = CantidadDeElementosEnLista();
                for(int i = 0; i < cantidadEnLista; i++) 
                { 
                    Auxiliar = Actual;
                    Actual = Actual.Siguiente;
                    if (menorEnLista > Actual.Persona.Edad)
                    {
                        if(_primero.Persona.Nombre == Actual.Persona.Nombre)
                        {
                            menorEnLista = Actual.Persona.Edad;
                            _primero = Actual;
                            Auxiliar = Auxiliar.Siguiente;
                            _primero.Siguiente = Auxiliar;
                            i--;
                        }
                        else
                        {
                            menorEnLista = Actual.Persona.Edad;
                            Auxiliar = Auxiliar.Siguiente;
                            Actual.Siguiente = Auxiliar;
                            i--;
                        }
                    }
                    else if (mayorEnLista < Actual.Persona.Edad)
                    {
                        mayorEnLista = Actual.Persona.Edad;
                        i--;
                    }
                }
             }
                Nodo Final = _primero;
                while (Final.Siguiente != null)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write($"Nombre: {Final.Persona.Nombre} ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"Edad: {Final.Persona.Edad}.\n");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"Nombre: {Final.Persona.Nombre} ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write($"Edad: {Final.Persona.Edad}.\n");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

    }
}
