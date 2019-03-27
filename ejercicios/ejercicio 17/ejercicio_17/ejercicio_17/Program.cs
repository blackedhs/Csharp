using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
  class Program
  {
    static void Main(string[] args)
    {
      Boligrafo boligrafoAzul = new Boligrafo(100, ConsoleColor.Blue);
      Boligrafo boligrafoRojo = new Boligrafo(50, ConsoleColor.Red);
      bool menu=true;
      int opcion;
      do
      { 
        Console.Clear();
        Console.WriteLine("Ingrese la opcion deseada");
        Console.WriteLine("1:Recargar Boligrafo Azul - {0} tinta", boligrafoAzul.GetTinta());
        Console.WriteLine("2:Recargar Boligrafo Rojo - {0} tinta", boligrafoRojo.GetTinta());
        Console.WriteLine("3:Pintar");
        Console.WriteLine("4:Salir");
        while(int.TryParse(Console.ReadLine(),out opcion)==false)
        {
          Console.WriteLine("INTENTE NUEVAMENTE");
          Console.WriteLine("Ingrese la opcion deseada");
        }
        switch (opcion)
        {
          case 1:
            boligrafoAzul.Recargar();              
            break;
          case 2:
            boligrafoRojo.Recargar();
            break;
          case 3:
            Console.Clear();
            Console.WriteLine("Que boligrafo desea usar?");
            Console.WriteLine("1:Boligrafo Azul - {0} tinta", boligrafoAzul.GetTinta());
            Console.WriteLine("2:Boligrafo Rojo - {0} tinta", boligrafoRojo.GetTinta());
            Console.WriteLine("Ingrese la opcion deseada");
            while (int.TryParse(Console.ReadLine(), out opcion) == false)
            {
              Console.Clear();
              Console.WriteLine("Que boligrafo desea usar?");
              Console.WriteLine("1:Boligrafo Azul - {0} tinta", boligrafoAzul.GetTinta());
              Console.WriteLine("2:Boligrafo Rojo - {0} tinta", boligrafoRojo.GetTinta());
              Console.WriteLine("INTENTE NUEVAMENTE");
              Console.WriteLine("Ingrese la opcion deseada");
            }
            switch (opcion)
            {
              case 1:

                boligrafoAzul.Pintar()
                break;
            }
            break;
          case 4:
            menu = false;
            break;
        }
      } while (menu);

    }
  }
}
