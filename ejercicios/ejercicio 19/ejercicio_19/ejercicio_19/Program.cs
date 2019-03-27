using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_19
{
  class Program
  {
    static void Main(string[] args)
    {
      Sumador calculo = new Sumador();
      Sumador calculo2 = new Sumador();

      Console.WriteLine(calculo.Sumar(5, 5));
      Console.WriteLine(calculo.Sumar("hola ","mundo"));
      Console.WriteLine((int)(calculo));
      Console.ReadKey();
      Console.WriteLine(calculo2.Sumar(10, 4));
      Console.WriteLine(calculo2.Sumar("Soy ", "sumador 2"));
      Console.WriteLine((int)(calculo2));
      Console.ReadKey();
    }
  }
}
