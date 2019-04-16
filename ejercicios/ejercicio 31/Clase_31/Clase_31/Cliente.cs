using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_31
{
  public class Cliente
  {
    private string nombre;
    private int numero;

    public int Numero
    {
      get { return numero; }
      set { numero = value; }
    }
    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }
    public Cliente(int numero)
    {
      this.numero = numero;
    }
    public Cliente(int numero,string nombre):this(numero)
    {
      this.nombre = nombre;
    }
    public static bool operator !=(Cliente c1,Cliente c2)
    {
      return c1.numero != c2.numero ? true : false;
    }
    public static bool operator ==(Cliente c1, Cliente c2)
    {
      return c1.numero == c2.numero ? true : false;
    }
  }
}
