using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Producto
{
  public class Estante
  {
    int ubicacionEstante;
    Producto[] productos;

    Estante (int capacidad)
    {
      this.productos = new Producto[capacidad];
    }
    public Estante(int capacidad,int ubicacion):this (capacidad)
    {
      this.ubicacionEstante = ubicacion;
    }
    public Producto[] GetProductos()
    {
      return productos;
    }
    public static string MostrarEstante(Estante e)
    {
      string ret;
      int length;
      length = e.productos.Length;
      ret = "Ubicacion del Estante = " + e.ubicacionEstante;
      for (int i = 0; i < length; i++)
      {
        if (e.productos[i] is null)
          return ret;
        ret = "\n" + ret + " " + Producto.MostrarProducto(e.productos[i]);
      }
      return ret;
    }
    public static bool operator !=(Estante e, Producto p)
    {

      return true;
    }
    public static Estante operator -(Estante e, Producto p)
    {

      return e;
    }
    public static bool operator +(Estante e, Producto p)
    {
      return true;
    }
    public static bool operator ==(Estante e, Producto p)
    {
      for (int i = 0; i < e.productos.Length; i++)
      {
        if((string)e.productos[i] == (string)p)
        {
          return true;
        }
      }
      return false;
    }
  }
}
