using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_31
{
  public class PuestoAtencion
  {
    private static int numeroActual;
    private Puesto puesto;
    public enum Puesto { Caja1,Caja2}
    public int NumeroActual
    {
      get { return numeroActual; }
      set { numeroActual ++; }
    }
    private PuestoAtencion()
    {
      numeroActual = 0;
    }
    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }
    public bool Atender(Cliente cli)
    {
      System.Threading.Thread.Sleep(3000);
      return true;
    }
  }
}
