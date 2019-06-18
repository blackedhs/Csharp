using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract class Persona
  {
    private int dni;
    private string apellido;
    private int edad;
    private string nombre;

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }


    public int Edad
    {
      get { return edad; }
      set { edad = value; }
    }


    public string Apellido
    {
      get { return apellido; }
      set { apellido = value; }
    }


    public int Dni
    {
      get { return dni; }
      set { dni = value; }
    }

    public virtual string Mostrar()
    {
      return "Nombre : " + Nombre + " Apellido :" + Apellido + " Dni : " + Dni + " Edad : " + Edad;
    }
    public Persona(string nombre,string apellido,int edad,int dni)
    {
      Nombre = nombre;
      Apellido = apellido;
      Dni = dni;
      Edad = edad;
    }
    public abstract bool ValidadAptitud();
  }
}
