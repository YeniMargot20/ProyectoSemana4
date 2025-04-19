using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana4 // Que es Namespace es el repositorio que agrupa todo un proyecto
{
    public class ArbolBinario
    {
        private Nodo raiz;
        public void Insertar (int valor)
        {
            raiz = InsertarRecursiva( raiz, valor);
        }
        private Nodo InsertarRecursiva (Nodo actual, int valor)
        {
            if (actual == null)
            {
                return new Nodo(valor);
            }
            // Si Valor es menor se inserta al lado izquierdo
            if (valor < actual.info)
            {
                actual.izquierda = InsertarRecursiva(actual.izquierda, valor);
                // Si valor esw mayor info se inserta al lado derecho
            }
            else if(valor > actual.info)
            {
                actual.derecha = InsertarRecursiva(actual.derecha, valor);
            }
            // Retorna la direccion del nodo actual insertado
            return actual;

        }
        // Recorrido en InOrden 
        public void RecorridoInorden()
        {
            RecorridoInorden(raiz);
        }
        private void RecorridoInorden(Nodo nodo)
        {// Recorrido Inorden IRD
            if (nodo != null)
            {
                RecorridoInorden(nodo.izquierda);
                Console.Write("{0},", nodo.info);
                RecorridoInorden(nodo.derecha);
            }
        }
        // Recorrido PreOrden  RID
        public void RecorridoPreOrden()
        {
            RecorridoPreOrden(raiz);
        }
        public void RecorridoPreOrden (Nodo nodo)
        {
            if(nodo != null)
            {

                Console.Write("{0},", nodo.info);
                RecorridoPreOrden(nodo.izquierda);
                RecorridoPreOrden(nodo.derecha);
            }
        }
        // Recorrido PostOrden
        public void RecorridoPostOrden()
        {
            RecorridoPostOrden(raiz);
        }
        public void RecorridoPostOrden(Nodo nodo)
        {
            if (nodo != null)
            {
                RecorridoPostOrden(nodo.izquierda);
                RecorridoPostOrden(nodo.derecha);
                Console.Write("{0},", nodo.info);
            }
        }
    }
}
