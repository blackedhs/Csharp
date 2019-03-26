using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace objetos_clase3
{
  class Alumno
  {
    byte nota1;
    byte nota2;
    float notaFinal;
    public string apellido;
    public int legajo;
    public string nombre;
    static string colegio;
    static Random rnd;

    public Alumno(string apellido,string nombre,int legajo)
    {
      this.apellido = apellido;
      this.nombre = nombre;
      this.legajo = legajo;

    }
    static Alumno()
    {
      colegio = "UTN";
      rnd = new Random();
    }
    public void Estudiar(byte notaUno,byte notaDos)
    {
      this.nota1 = notaUno;
      this.nota2 = notaDos;
    }
    public void CalcularFinal()
    {
      if(this.nota2>4 && this.nota1 > 4)
      {
        this.notaFinal = (this.nota1 + this.nota2) / 2;
      }
      else
      {
        this.notaFinal = -1;
      }
    }
    public void Mostrar()
    {
      Console.WriteLine("Apellido : {0}", this.apellido);
      Console.WriteLine("Nombre : {0}", this.nombre);
      Console.WriteLine("Legajo : {0}", this.legajo);
      Console.WriteLine("Nota 1 : {0}", this.nota1);
      Console.WriteLine("Nota 2 : {0}", this.nota2);
      if (this.notaFinal != -1)
      {
        Console.WriteLine("Nota final : {0}", this.notaFinal);
      }
      else
      {
        Console.WriteLine("Nota final : desaprobado");
      }
      Console.WriteLine("Colegio : {0}", colegio);
    }
  }
}
