using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Centralita
  {
    private static List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciasPorLocal
    {
      get
      {
        float valor = 0;
        foreach (Llamada llamada in listaDeLlamadas)
        {
          if (llamada is Local)
            valor += ((Local)llamada).CostoLlamada;
        }
        return valor;
      }
    }
    public float GananciasPorProvincial
    {
      get
      {
        float valor = 0;
        foreach (Llamada llamada in listaDeLlamadas)
        {
          if (llamada is Provincial)
            valor += ((Provincial)llamada).CostoLlamada;
        }
        return valor;
      }
    }
    public float GanaciasPorTotal
    {
      get
      {
        float valor = 0;
        foreach (Llamada llamada in listaDeLlamadas)
        {
          if (llamada is Local)
            valor += ((Local)llamada).CostoLlamada;
          else
            valor += ((Provincial)llamada).CostoLlamada;
        }
        return valor;
      }
    }
    public List<Llamada> Llamadas
    {
      get
      {
        return listaDeLlamadas;
      }
    }

    private float CalcularGanancia(Llamada.TipoLlamada tipo)
    {
      float valor = 0;
      switch (tipo)
      {
        case Llamada.TipoLlamada.Local:
          valor = this.GananciasPorLocal;
          break;
        case Llamada.TipoLlamada.Provincial:
          valor = this.GananciasPorProvincial;
          break;
        case Llamada.TipoLlamada.Todas:
          valor = this.GanaciasPorTotal;
          break;
      }
      return valor;
    }
    static Centralita()
    {
      listaDeLlamadas = new List<Llamada>();
    }
    public Centralita(string nombreEmpresa)
    {
      this.razonSocial = nombreEmpresa;
    }
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("*****************************************************");
      sb.AppendLine("Razon social         : " + this.razonSocial);
      sb.AppendLine("Ganancia Total       : " + CalcularGanancia(Llamada.TipoLlamada.Todas));
      sb.AppendLine("Ganancias Local      : " + CalcularGanancia(Llamada.TipoLlamada.Local));
      sb.AppendLine("Ganancias Provincial : " + CalcularGanancia(Llamada.TipoLlamada.Provincial));
      sb.AppendLine("*****************************************************");
      foreach (Llamada llamada in listaDeLlamadas)
      {
        sb.AppendLine(llamada.ToString());
      }
      return sb.ToString();
    }
    public void OrdenarLlamadas()
    {
      this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
    }
    public static Centralita operator +(Centralita c, Llamada l)
    {
      if (c != l)
        c.AgregarLLamada(l);
      else
        throw new CentralitaException("No se pudo realizar la llamada", "Centralita", "+");
      return c;
    }
    public static bool operator ==(Centralita c, Llamada l)
    {
      foreach (Llamada llamada in c.Llamadas)
      {
        if (llamada==l)
          return true;
      }
      return false;
    }
    public static bool operator !=(Centralita c, Llamada l)
    {
      return !(c == l);
    }
    private void AgregarLLamada(Llamada l)
    {
      this.Llamadas.Add(l);
    }
  }
}
