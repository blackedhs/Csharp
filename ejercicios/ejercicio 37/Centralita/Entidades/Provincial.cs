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
    public float CostoLlamada { get; }
    private float CalcularCosto()
    {
      float valor=0;
      switch (this.franjaHoraria)
      {
        case Franja.Franja_1:
          valor = Duracion *(float) 0.99;
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
    public string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar());
      sb.AppendLine("Franja Horaria       : " + this.franjaHoraria);
      sb.AppendLine("Costo                : " + CostoLlamada);
      return sb.ToString();
    }
    public Provincial(Franja miFranja,Llamada llamada) : base(llamada.Duracion, llamada.NroDestino,llamada.NroOrigen)
    {
      this.franjaHoraria = miFranja;
    }
    public Provincial(string origen, Franja mifranja, float duracion,string destino): this(mifranja,new Llamada(duracion,destino,origen))
    {
    }
  }
}
