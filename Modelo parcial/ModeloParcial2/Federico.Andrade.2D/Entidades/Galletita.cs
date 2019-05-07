using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita : Producto
    {
        private float peso;
        private static bool deConsumo;
        public override float CalcularCostoProducion()
        {
            return this.Precio * (float)1.33;
        }
        static Galletita()
        {
            deConsumo = true;
        }
        public Galletita(int codigoBarra, EMarcaProducto marca, float precio,float peso): base(codigoBarra, marca, precio)
        {
            this.peso = peso;
            Tipo = ETipoProducto.Harina;
        }
        private string MostrarGalletita()
        {
            return (string)this + "Peso: " + this.peso +" "+Consumir();
        }
        public string ToString()
        {
            return MostrarGalletita();
        }
        public override string Consumir()
        {
            return "Comestible";
        }

        public override bool Equals(object obj)
        {
            return obj is Galletita ? true : false; ;
        }
    }
}
