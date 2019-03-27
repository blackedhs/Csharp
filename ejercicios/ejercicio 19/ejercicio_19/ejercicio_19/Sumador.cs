using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19
{
  class Sumador
  {
    int cantidadSumas;

    public static explicit operator int (Sumador s)
    {
      return s.cantidadSumas;
    }
 /*
    public bool OperadorO(Sumador s1,Sumador s2)
    {
      return false;
    }
    public long OperadorSuma(Sumador s1,Sumador s2)
    {
      return 1;
    }
 */
    public Sumador():this(0)
    {

    }
    public Sumador(int cantidadSumas)
    {

    }
    public long Sumar(long a, long b)
    {
      this.cantidadSumas++;
      return a + b;
    }
    public string Sumar(string a,string b)
    {
      this.cantidadSumas++;
      return a + b;
    }
    public int GetCantidadSumas()
    {
      return this.cantidadSumas;
    }
  }
}
