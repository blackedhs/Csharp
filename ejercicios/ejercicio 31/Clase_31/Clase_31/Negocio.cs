using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_31
{
  public class Negocio
  {
    private Queue<Cliente> clientes;
    private PuestoAtencion caja;
    private string nombre;

    public  Cliente Clientes
    {
      get { return clientes; }
      set { clientes = value; }
    }
    private Negocio()
    {

    }
    public  Negocio(string nombre)
    {
      this.nombre = nombre;
    }
    public static bool operator !=(Negocio n,Cliente c)
    {
      return true;
    }
    public static bool operator ~(Negocio n)
    {
      return true;
    }
    public static bool operator +(Negocio n, Cliente c)
    {
      return true;
    }
    public static bool operator ==(Negocio n, Cliente c)
    {
      return true;
    }
  }
}
