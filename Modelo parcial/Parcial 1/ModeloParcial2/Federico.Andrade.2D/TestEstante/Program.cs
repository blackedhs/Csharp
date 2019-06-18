using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestEstante
{
    public class Program
    {
        static void Main(string[] args)
        {
        }
        public void sort(Estante e)
        {
            List<Producto> productos = e.GetProductos();
            productos.Sort()
        }
    }
}
