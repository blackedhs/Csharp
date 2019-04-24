using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
  class Program
  {
    static void Main(string[] args)
    {
      SobreSobreescritura objeto = new SobreSobreescritura();
      Sobreescrito objeto2 = objeto;
      Console.WriteLine(objeto);
      Console.WriteLine(objeto2.Equals(objeto));
      Console.ReadKey();
    }
  }
}
