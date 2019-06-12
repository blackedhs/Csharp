using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Negocio
  {
    private Caja caja1;
    private Caja caja2;
    private List<string> clientes;

    public Caja Caja1
    {
      get { return caja1; }
    }
    public Caja Caja2
    {
      get { return caja2; }
    }
    public List<string> Clientes
    {
      get { return clientes; }
    }
    public void Asignar()
    {

    }
    public Negocio(Caja c1,Caja c2)
    {
      this.caja1 = c1;
      this.caja2 = c2;
    }
  }
}
