using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Local : Llamada
  {
    private float costo;
    private float costoLlamada;

    public float CostoLlamada
    {
      get { return costoLlamada; }
      set { costoLlamada = value; }
    }
    public Local(Llamada llamada,float costo)
    {

    }
    public Local(string origen,float duracion,string destino,float costo) : base(duracion,destino,origen)
    {
      this.costo = costo;
    }
    public string Mostrar()
    {
      return (base.Mostrar() + "Costo: " + this.CostoLlamada);
    }
  }
}
