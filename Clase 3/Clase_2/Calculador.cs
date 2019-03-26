using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
  class Calculador
  {
    private int acumulador;

    public Calculador()
    {
      acumulador = 0;
    }
    public void Acumular(string binario)
    {
      int binTransformado;
      if(int.TryParse(binario,out binTransformado))
      {
        acumulador += binTransformado;
      }
    }
    public string GetRasultadoBinario()
    {
      return Convert.ToString(acumulador, 2);
    }
    public int GetResultadoEntero()
    {
      return acumulador;
    }

  }
}
