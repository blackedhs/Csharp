using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
  public class Euro
  {
    static float cotizRespectoDolar;
    double cantidad;

    static Euro()
    {
      cotizRespectoDolar = 0.84f;
    }
    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }
    public Euro(double cantidad, float cotizacion) : this(cantidad)
    {
      cotizRespectoDolar = cotizacion;
    }
    public static explicit operator Dolar(Euro e)
    {
      Dolar dolar = new Dolar(e.cantidad * cotizRespectoDolar);
      return dolar;
    }
    public static explicit operator Pesos(Euro e)
    {
      return (Pesos)(Dolar)e;
    }
    public double GetCantidad()
    {
      return this.cantidad;
    }
    public static float GetCotizacion()
    {
      return cotizRespectoDolar;
    }
    public static implicit operator Euro(double d)
    {
      Euro euro = new Euro(d);
      return euro;
    }
    public static bool operator !=(Euro p, Euro e)
    {
      Euro euro = (Euro)e;
      return p.cantidad != euro.cantidad;
    }
    public static bool operator !=(Euro p, Dolar d)
    {
      Euro euro = (Euro)d;
      return p.cantidad != euro.cantidad;
    }
    public static bool operator -(Euro p, Dolar d)
    {
      Euro euro = (Euro)d;
      return p.cantidad < euro.cantidad;
    }
    public static bool operator -(Euro p, Euro e)
    {
      Euro euro = (Euro)e;
      return p.cantidad < euro.cantidad; ;
    }
    public static bool operator +(Euro p, Dolar d)
    {
      Euro euro = (Euro)d;
      return p.cantidad < euro.cantidad;
    }
    public static bool operator +(Euro p, Euro e)
    {
      Euro euro = (Euro)e;
      return p.cantidad > euro.cantidad; ;
    }
    public static bool operator ==(Euro p, Euro e)
    {
      Euro euro = (Euro)e;
      return p.cantidad == euro.cantidad;
    }
    public static bool operator ==(Euro p, Dolar d)
    {
      Euro euro = (Euro)d;
      return p.cantidad == euro.cantidad;
    }
   
  }
}
