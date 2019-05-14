using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Llamada
    {
      public enum TipoDeLlamada
    {
      Local,
      Provincia,
      Todas
    }
    private float duracion;
    private string nroDestino;
    private string nroOrigen;

    public string NroOrigen
    {
      get { return nroOrigen; }
      set { nroOrigen = value; }
    }

    public string NroDestino
    {
      get { return nroDestino; }
      set { nroDestino = value; }
    }

    public float Duracion
    {
      get { return duracion; }
      set { duracion = value; }
    }
    public Llamada(float duracion,string nroDestino,string nroOrigen)
    {
      Duracion = duracion;
      NroDestino = nroDestino;
      NroOrigen = NroOrigen;
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Duracion: " + Duracion);
      sb.AppendLine("Numero Destino: " + NroDestino);
      sb.AppendLine("Numero Origen " + NroOrigen);
      return sb.ToString();
    }
     public int OrdenarPorDuracion(Llamada llamada1,Llamada llamada2)
    {
      return llamada1.Duracion > llamada2.Duracion ? 1 : -1;
    }

  }
}
