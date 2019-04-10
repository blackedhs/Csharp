using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
  public class Dolar
  {
    static float cotizRespectoDolar;
    double cantidad;

    static Dolar()
    {
      cotizRespectoDolar = 1;
    }
    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Dolar(double cantidad,float cotizacion):this (cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }
    public static explicit operator Euro(Dolar d)
    {
      Euro euro = new Euro(d.cantidad * Euro.GetCotizacion());

      return euro;
    }
    public static explicit operator Pesos(Dolar d)
    {
      Pesos pesos = new Pesos(d.cantidad / Pesos.GetCotizacion());
      return pesos;
    }
    public double GetCantidad()
    {
      return this.cantidad;
    }
    static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }
    public static implicit operator Dolar(double d)
    {
      Dolar dolar = new Dolar(d);
      return dolar;
    }
    public static bool operator !=(Dolar d,Euro e)
    {
      Dolar dolar = (Dolar)e;
      return d.cantidad != dolar.cantidad;
    }
    public static bool operator !=(Dolar d, Pesos p)
    {
      Dolar dolar = (Dolar)p;
      return d.cantidad != dolar.cantidad;
    }
    public static bool operator !=(Dolar d1, Dolar d2)
    {
      return d1.cantidad != d2.cantidad;
    }
    public static bool operator -(Dolar d, Euro e)
    {
      Dolar dolar = (Dolar)e;
      return d.cantidad<dolar.cantidad;
    }
    public static bool operator -(Dolar d, Pesos p)
    {
      Dolar dolar = (Dolar)p;
      return d.cantidad < dolar.cantidad; ;
    }
    public static bool operator +(Dolar d, Euro e)
    {
      Dolar dolar = (Dolar)e;
      return d.cantidad > dolar.cantidad; ;
    }
    public static bool operator +(Dolar d, Pesos p)
    {
      Dolar dolar = (Dolar)p;
      return d.cantidad > dolar.cantidad; ;
    }
    public static bool operator ==(Dolar d, Euro e)
    {
      Dolar dolar = (Dolar)e;
      return d.cantidad == dolar.cantidad; ;
    }
    public static bool operator ==(Dolar d, Pesos p)
    {
      Dolar dolar = (Dolar)p;
      return d.cantidad == dolar.cantidad; ;
    }
    public static bool operator ==(Dolar d1, Dolar d2)
    {
      return d1.cantidad == d2.cantidad; ;
    }
  }
}
