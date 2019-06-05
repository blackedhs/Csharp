using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Local : Llamada
    {
        protected float costo;
        private float costoLlamada;

        public override float CostoLlamada
        {
            get { return CalcularCosto(); }
        }
        public Local(Llamada llamada, float costo) : this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino,costo)
        {
            
        }
        public Local(string origen, float duracion, string destino, float costo) : base(duracion, destino, origen)
        {
            this.costo = costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*********** Local **************");
            sb.Append(base.Mostrar());
            sb.AppendLine("Costo         : " + CostoLlamada);
            
            return sb.ToString();
        }
        private float CalcularCosto()
        {
            return Duracion * this.costo;
        }
        public bool Equals(Llamada llamada)
        {
            return llamada is Local;
        }
        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
