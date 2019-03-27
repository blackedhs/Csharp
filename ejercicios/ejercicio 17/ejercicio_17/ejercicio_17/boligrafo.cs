using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_17
{
  class Boligrafo
  {
    short cantidadTintaMinima;
    ConsoleColor color;
    short tinta;
    const short cantidadTintaMaxima = 100;

    public Boligrafo(short tinta, ConsoleColor color)
    {
      this.tinta = tinta;
      this.color = color;
    }
    public ConsoleColor GetColor()
    {
      return this.color;
    }
    public short GetTinta()
    {
      return this.tinta;
    }
    public bool Pintar(int gasto, out string dibujo)
    {
      bool ret = false;
      dibujo = "";
      if(this.tinta>0 && this.tinta+gasto > 0)
      {
        SetTinta((short)gasto);
        ret = true;
        for(int i = 0; i < gasto; i++)
        {
          dibujo = "*" + dibujo;
        }
      }
      else
      {
        for(int i=0;i < this.tinta; i++)
        {
          dibujo = "*" + dibujo;
        }
      }    
      return ret;
    }
    public void Recargar()
    {
      this.tinta = cantidadTintaMaxima;
    }
    private void SetTinta(short tinta)
    {
      tinta += this.tinta;
      if (tinta >0 && tinta < cantidadTintaMaxima )
      {
        this.tinta += tinta;
      }
    }
  }
}
