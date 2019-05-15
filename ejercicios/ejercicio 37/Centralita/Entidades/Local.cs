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

    public float CostoLlamada
    {
      get { return CalcularCosto(); }
    }
    public Local(Llamada llamada,float costo):base (llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
    {
      this.costo = costo;
    }
    public Local(string origen,float duracion,string destino,float costo) : this(new Llamada(duracion,destino,origen),costo)
    {
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Costo: " + CostoLlamada);
      return sb.ToString();
    }
    private float CalcularCosto()
    {
      return Duracion * this.costo;
    }
  }
}
