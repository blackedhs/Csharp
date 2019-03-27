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
      int entero = 0;

      for (int i = 1; i <= binario.Length; i++)
      {
        entero += int.Parse(binario[i - 1].ToString()) * (int)Math.Pow(2, binario.Length - i);
      }
      acumulador += entero;
    }
    public string GetRasultadoBinario()
    {
      string binario="";
      while (acumulador > 0)
      {
        binario = (acumulador % 2).ToString() + binario;
        acumulador = acumulador / 2;
      }
      return binario;
    }
    public int GetResultadoEntero()
    {
      return acumulador;
    }

  }
}
