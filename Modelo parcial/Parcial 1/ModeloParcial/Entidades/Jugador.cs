using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Jugador : Persona
  {
    private float altura;
    private float peso;
    private Posicion posicion;

    public Posicion Posicion
    {
      get { return posicion; }
      set { posicion = value; }
    }


    public float Peso
    {
      get { return peso; }
      set { peso = value; }
    }


    public float Altura
    {
      get { return altura; }
      set { altura = value; }
    }
    public Jugador(string nombre,string apellido,int edad,int dni,float peso,float altura,Posicion posicion):base(nombre,apellido,edad,dni)
    {
      Posicion = posicion;
      Altura = altura;
      Peso = peso;
    }
    public override string Mostrar()
    {
      return base.Mostrar() + "Altura :" + Altura + " Peso : " + Peso + " Posicion :" + posicion;
    }
    public override bool ValidadAptitud()
    {
      return (Edad <= 40 && ValidarEstadoFisico()) ? true : false;
    }
    public bool ValidarEstadoFisico()
    {
      float imc = Peso / (float)Math.Pow(Altura, 2);
      return (imc >= 18.5 && imc <= 25) ? true : false;
    }
  }
}
