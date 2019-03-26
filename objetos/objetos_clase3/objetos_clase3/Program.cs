using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos_clase3
{
  class Program
  {
    static void Main(string[] args)
    {
      Alumno alumno1 = new Alumno("Andrade","Federico",101);
      
      alumno1.Estudiar(7, 7);
      alumno1.CalcularFinal();
      alumno1.Mostrar();
      Console.ReadKey();
    }
  }
  
}
