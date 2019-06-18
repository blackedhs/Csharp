using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina:Producto
    {
        public enum ETipo
        {
            CuatroCeros,
            TresCeros,
            Integral,
        }
        private ETipo tipo;
        private static bool deConsumo;
        public override float CalcularCostoProducion()
        {
            return this.Precio * (float)1.60;
        }
        static Harina()
        {
            deConsumo = true;
        }
        public Harina(int codigoBarra, float precio, EMarcaProducto marca, ETipo tipo) : base(codigoBarra, marca, precio)
        {
            this.tipo = tipo;
            Tipo = ETipoProducto.Harina;
        }
        private string MostrarHarina()
        {
            return (string)this + "Tipo : " + this.tipo + " " + Consumir();
        }
        public string ToString()
        {
            return MostrarHarina();
        }
        public override string Consumir()
        {
            return "Comida";
        }

        public override bool Equals(object obj)
        {
            return obj is Harina ? true : false; ;
        }
    }
}
