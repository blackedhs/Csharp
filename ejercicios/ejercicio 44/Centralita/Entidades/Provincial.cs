using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincial : Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        protected Franja franjaHoraria;
        public override float CostoLlamada { get { return CalcularCosto(); } }
        private float CalcularCosto()
        {
            float valor = 0;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    valor = Duracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    valor = Duracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    valor = Duracion * (float)0.66;
                    break;
            }
            return valor;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********** Provincial **************");
            sb.Append(base.Mostrar());
            sb.AppendLine("Franja Horaria: "+ this.franjaHoraria);
            sb.AppendLine("Costo         : " + CostoLlamada);
            
            return sb.ToString();
        }
        public Provincial(Franja miFranja, Llamada llamada) : this(llamada.NroOrigen,miFranja, llamada.Duracion, llamada.NroDestino)
        {            
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) :base(duracion, destino, origen)
        {
            this.franjaHoraria = miFranja;
        }
        public bool Equals(Llamada llamada)
        {
            return llamada is Provincial;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
