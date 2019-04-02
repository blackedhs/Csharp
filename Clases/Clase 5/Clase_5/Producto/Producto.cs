using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
  public class Producto
  {
    string codigoDeBarra;
    string marca;
    float precio;

    public static explicit operator string(Producto p)
    {
      return p.codigoDeBarra;
    }
    public string GetMarca()
    {
      return this.marca;
    }
    public float GetPrecio()
    {
      return this.precio;
    }
    public static string MostrarProducto(Producto p)
    {
      string ret="Codigo de barras "+p.codigoDeBarra+" Marca = "+p.marca+" Precio = "+ p.precio;
      return ret; 
    }
    public static bool operator != (Producto p, string marca)
    {
      if (p.marca == marca)
      {
        return false;
      }
      return true;
    }
    public static bool operator !=(Producto p, Producto p2)
    {
      if(p.marca == p2.marca)
      {
        return false;
      }
      return true;
    }
    public static bool operator ==(Producto p, string marca)
    {
      if (p.marca == marca)
      {
        return true;
      }
      return false;
    }
    public static bool operator ==(Producto p, Producto p2)
    {
      if (p.marca == p2.marca && p.codigoDeBarra == p2.codigoDeBarra)
      {
        return true;
      }
      return false;
    }
    public Producto(string marca,string codigo,float precio)
    {
      this.marca = marca;
      this.codigoDeBarra = codigo;
      this.precio = precio;
    }
  }
}
