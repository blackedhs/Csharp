using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        private int codigoBara;
        private EMarcaProducto marca;
        private float precio;
        private ETipoProducto tipo;

        public ETipoProducto Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranju,
            Division,
            Swift,
            Favorita
        }
        public abstract float CalcularCostoProducion();
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public EMarcaProducto Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        private string MostrarProcuto()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Marca: " + Marca);
            sb.AppendLine("Precio: " + Precio);
            sb.AppendLine("Tipo: " + tipo);
            sb.AppendLine("Codigo de Barra: " + codigoBara);
            return sb.ToString();
        }
        public Producto(int codigoBarra, EMarcaProducto marca, float precio)
        {
            Precio = precio;
            codigoBara = codigoBarra;
            Marca = marca;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            return p1.Marca == p2.Marca && p1.codigoBara == p2.codigoBara
                    && p1.tipo == p2.tipo ? true : false;

        }
        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1.Marca == p2.Marca && p1.codigoBara == p2.codigoBara
                && p1.tipo == p2.tipo ? true : false;
        }
        public static bool operator ==(Producto p1, EMarcaProducto marca)
        {
            return p1.Marca == marca ? true : false;
        }
        public static bool operator !=(Producto p1, EMarcaProducto marca)
        {
            return p1.Marca == marca ? false : true;
        }
        public static explicit operator int(Producto p)
        {
            return p.codigoBara;
        }
        public static implicit operator string(Producto p)
        {
            return p.MostrarProcuto();
           
        }
        public virtual string Consumir()
        {
            return "Parte de una mezcla";
        }
        public abstract bool Equals(Object obj);
    }
}
