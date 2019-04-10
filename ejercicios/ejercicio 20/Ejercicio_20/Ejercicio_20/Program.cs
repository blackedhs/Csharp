using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
  class Program
  {
    static void Main(string[] args)
    {
      Dolar dolar = 25;
      Pesos pesos = (Pesos)dolar;
      Euro euro = (Euro)dolar;
      Console.WriteLine("{0}   {1}    {2} " , pesos.GetCantidad(),dolar.GetCantidad(),euro.GetCantidad());
      Console.ReadKey();

    }
  }
}
