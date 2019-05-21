using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Llamada
  {
    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas
    }
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

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
    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      Duracion = duracion;
      NroDestino = nroDestino;
      NroOrigen = nroOrigen;
    }
    public string Mostrar()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Duracion      : " + Duracion);
        sb.AppendLine("Numero Destino: " + NroDestino);
        sb.AppendLine("Numero Origen : " + NroOrigen);
        return sb.ToString(); 
    }
    public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
    {
      return llamada1.Duracion > llamada2.Duracion ? 1 : -1;
    }

  }
}
