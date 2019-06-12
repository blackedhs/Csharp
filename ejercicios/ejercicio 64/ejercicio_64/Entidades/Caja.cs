using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Caja
  {
    private List<string> filaClientes;

    public List<string> FilaClientes
    {
      get { return filaClientes; }
      set { filaClientes = value;}
    }
    public void AtenderClientes()
    {

    }
    public Caja()
    {

    }
  }
}
