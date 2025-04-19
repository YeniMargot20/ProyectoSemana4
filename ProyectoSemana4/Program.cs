using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ArbolBinario arbol = new ArbolBinario();
           for (int i=1;i<=10; ++i)
            {
                arbol.Insertar(rnd.Next(10, 99));
                // llamar al recorrido
                Console.WriteLine("\n--- RECORRIDO EN INORDEN---");
                arbol.RecorridoInorden();
                Console.WriteLine("\n--- RECORRIDO EN PREORDEN---");
                arbol.RecorridoPreOrden();

                Console.WriteLine("\n--- RECORRIDO EN POSTORDEN---");
                arbol.RecorridoPostOrden();

            }
        }
    }
}
