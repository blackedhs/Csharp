using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class DirectorTecnico: Persona
  {
    private int añosExperiencia;

    public int AñosExperiencia
    {
      get { return añosExperiencia; }
      set { añosExperiencia = value; }
    }
    public DirectorTecnico(string nombre,string apellido,int edad,int dni,int añosExperiencia):base(nombre,apellido,edad,dni)
    {
      AñosExperiencia = añosExperiencia;
    }
    public override string Mostrar()
    {
      return base.Mostrar() + "años de experiencia :" + AñosExperiencia;
    }
    public override bool ValidadAptitud()
    {      
      return (Edad <65 && AñosExperiencia>=2)? true:false;
    }

  }
}
