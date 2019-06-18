using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa : Producto
    {
        private float litros;
        private static bool deConsumo;
        public override float CalcularCostoProducion()
        {
            return this.Precio * (float)1.42;
        }
        static Gaseosa()
        {
            deConsumo = true;
        }
        public Gaseosa(int codigoBarra, float precio, EMarcaProducto marca, float litros) : base(codigoBarra, marca, precio)
        {
            this.litros = litros;
            Tipo = ETipoProducto.Gaseosa;
        }
        private string MostrarGaseosa()
        {
            return (string)this + "Litros : " + this.litros + " " + Consumir();
        }
        public string ToString()
        {
            return MostrarGaseosa();
        }
        public override string Consumir()
        {
            return "Bebible";
        }

        public override bool Equals(object obj)
        {
            return obj is Gaseosa ? true : false; ;
        }
    }
}
