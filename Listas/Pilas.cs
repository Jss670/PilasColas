using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Pilas
    {
        private List<string> list;
        public Pilas(int v)
        {
            list = new List<string>();
        }
        public void Agregar(string dato)
        {
            list.Add(dato);
        }
        private bool ValidaVacio()
        {
            return list.Count ==0;
        }
        public void Eliminar()
        {
            if (ValidaVacio())
            {
                throw new Exception("Lista Vacia");
            }
            list.RemoveAt(list.Count-1);
        }
        public string Imprimir()
        {
            string datos = "";

            if (ValidaVacio())
            {
                return "Lista Vacia";
            }
            int lstCount = list.Count;
            for (int i = 0; i < lstCount; i++)
            {
                if (i > 0)
                {
                    datos += "\n";
                }
                datos += "$[{ i}]-{ lista[{ i}]}";

            }
            return datos;
        }
    }
}