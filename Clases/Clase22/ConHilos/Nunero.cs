using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase22
{
  public delegate void MuestraNumeroDelegate(int numero, int posicion);
  public class Numero
  {

    public event MuestraNumeroDelegate MuestraNumeroEvent;
    public Numero(int posicion)
    {
      this.posicion = posicion;
      Num = 0;
    }
    public int posicion { get; set; }


    public int Num { get; set; }

    public void sumar()
    {
      while (Num < 5000)
      {
        try
        {

          System.Threading.Thread.Sleep(40);
          Num++;
          MuestraNumeroEvent.Invoke(Num, posicion);
        }
        catch (ThreadInterruptedException e)
        {

        }
      }

    }
  }
}
