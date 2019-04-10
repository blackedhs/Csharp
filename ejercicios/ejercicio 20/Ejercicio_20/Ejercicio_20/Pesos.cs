using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
  public class Pesos
  {
    static float cotizRespectoDolar;
    double cantidad;

    static Pesos()
    {
      cotizRespectoDolar = 0.26f;
    }
    public Pesos(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Pesos(double cantidad, float cotizacion) : this(cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }
    public static explicit operator Dolar(Pesos p)
    {
      Dolar dolar = new Dolar(p.cantidad * Pesos.GetCotizacion());

      return dolar;
    }
    public static explicit operator Euro(Pesos p)
    {
      return (Euro)(Dolar)p ;
    }
    public double GetCantidad()
    {
      return this.cantidad;
    }
    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }
    public static implicit operator Pesos(double p)
    {
      Pesos pesos = new Pesos(p);
      return pesos;
    }
    public static bool operator !=(Pesos p, Euro e)
    {
      Pesos pesos = (Pesos)e;
      return p.cantidad != pesos.cantidad;
    }
    public static bool operator !=(Pesos p, Dolar d)
    {
      Pesos pesos = (Pesos)d;
      return p.cantidad != pesos.cantidad;
    }
    public static bool operator !=(Pesos p1, Pesos p2)
    {
      return p1.cantidad != p2.cantidad;
    }
    public static bool operator -(Pesos p, Dolar d)
    {
      Pesos pesos = (Pesos)d;
      return p.cantidad < pesos.cantidad;
    }
    public static bool operator -( Pesos p,Euro e)
    {
      Pesos pesos = (Pesos)e;
      return p.cantidad < pesos.cantidad; ;
    }
    public static bool operator +(Pesos p, Dolar d)
    {
      Pesos pesos = (Pesos)d;
      return p.cantidad < pesos.cantidad;
    }
    public static bool operator +(Pesos p, Euro e)
    {
      Pesos pesos = (Pesos)e;
      return p.cantidad > pesos.cantidad; ;
    }
    public static bool operator ==(Pesos p, Euro e)
    {
      Pesos pesos = (Pesos)e;
      return p.cantidad == pesos.cantidad;
    }
    public static bool operator ==(Pesos p, Dolar d)
    {
      Pesos pesos = (Pesos)d;
      return p.cantidad == pesos.cantidad;
    }
    public static bool operator ==(Pesos p1, Pesos p2)
    {
      return p1.cantidad == p2.cantidad;
    }
  }
}
