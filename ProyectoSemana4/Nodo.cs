using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSemana4
{
   public class Nodo
    {
        // campos o atributos de la clase 
        public int info { set; get; }
        public Nodo izquierda { set; get; }
        public Nodo derecha { set; get; }

        // Metodo constructor 
        public Nodo(int info)
        {
            this.info = info;
            this.izquierda = null;
            this.derecha = null;
        }

    }
}
