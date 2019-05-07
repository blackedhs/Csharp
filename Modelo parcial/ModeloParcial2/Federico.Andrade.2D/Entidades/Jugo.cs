using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo : Producto
    {
        public enum ESAborJugo
        {
            Asqueroso,
            Pasable,
            Rico,
        }
        private ESAborJugo sabor;
        private static bool deConsumo;
        public override float CalcularCostoProducion()
        {
            return this.Precio * (float)1.40;
        }
        static Jugo()
        {
            deConsumo = true;
        }
        public Jugo(int codigoBarra, float precio, EMarcaProducto marca, ESAborJugo sabor) : base(codigoBarra, marca, precio)
        {
            this.sabor = sabor;
            Tipo = ETipoProducto.Jugo;
        }
        private string MostrarJugo()
        {
            return (string)this + "Sabor : " + this.sabor + " " + Consumir();
        }
        public string ToString()
        {
            return MostrarJugo();
        }
        public override string Consumir()
        {
            return "Bebible";
        }

        public override bool Equals(object obj)
        {
            return obj is Jugo ? true: false;
        }
    }
}
