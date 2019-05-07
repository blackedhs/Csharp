using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        private sbyte capacidad;
        private List<Producto> productos;
        public float ValorEstanteTotal
        {
            get
            {
                float valor = 0;
                valor = this.GetValorEstante(ETipoProducto.Galletita) + this.GetValorEstante(ETipoProducto.Gaseosa)
                        + this.GetValorEstante(ETipoProducto.Harina) + this.GetValorEstante(ETipoProducto.Jugo);
                return valor;
            }
        }
        private Estante()
        {
            productos = new List<Producto>();
        }
        public Estante(sbyte capacidad): this()
        {
            this.capacidad = capacidad;
        }
        public List<Producto> GetProductos()
        {
            return productos;
        }
        public float GetValorEstante(ETipoProducto tipo)
        {
            float valor = 0;
            foreach (Producto producto in this.productos)
            {
                if (producto.Tipo == tipo)
                {
                    valor += valor + producto.Precio;       
                }
            }
            return valor;
        }
        public string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad: " + this.capacidad);
            sb.AppendLine("Productos");
            foreach(Producto producto in e.productos)
            {
                sb.AppendLine(producto.ToString());
            }

            return sb.ToString();
        }
        public static bool operator !=(Estante e, Producto prod)
        {
            return e.productos.Contains(prod) ? false : true;
        }
        public static bool operator ==(Estante e, Producto prod)
        {
            return e.productos.Contains(prod) ? true : false;
        }
        public static Estante operator -(Estante e, ETipoProducto tipo)
        {
            bool flag = false;
            do
            {
                flag = false;
                foreach (Producto producto in e.productos)
                {
                    if (producto.Tipo == tipo)
                    {
                        e = e -producto;
                        flag = true;
                        break;
                    }
                }                   
            } while (flag);
            return e;
        }
        public static Estante operator -(Estante e, Producto prod)
        {
            if (e == prod)
               e.productos.Remove(prod);
            return e;
        }
        public static bool operator +(Estante e, Producto prod)
        {
            return (e == prod) && (e.capacidad > (0) ? true : false;
        }
    }
}
