using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Equipo
  {
    private const int cantidadMaximaJugadores = 6;
    private DirectorTecnico directorTecnico;
    private List<Jugador> Jugadores;   
    private string nombre;

    public string Nombre
    {
      get { return nombre; }
      set { nombre = value; }
    }

    public DirectorTecnico DirectorTecnico
    {
      get { return directorTecnico; }
      set { directorTecnico = value; }
    }
    private Equipo()
    {
      Jugadores = new List<Jugador>();
    }
    public Equipo(string nombre):this()
    {
      Nombre = nombre;
    }
    public static explicit operator string(Equipo e)
    {
      StringBuilder sb = new StringBuilder();
      sb.Append("Nombre del equipo"+e.Nombre+e);
      if (e.directorTecnico is null)
        sb.Append("Sin Dt asignado");
      else
        sb.Append("DT" + e.directorTecnico.Apellido + " " + e.directorTecnico.Edad);
      foreach (Jugador jugador in e.Jugadores)
      {
        sb.Append("Jugador:/n Apellido :" + jugador.Apellido + " Nombre :" + jugador.Nombre);
      }
      return sb.ToString();
    }
    public static bool operator !=(Equipo e, Jugador j)
    {
      return e.Jugadores.Contains(j) ? false : true;
    }
    public static Equipo operator +(Equipo e, Jugador j)
    {
      if (e != j && e.Jugadores.Count() <cantidadMaximaJugadores && j.ValidadAptitud())
      {
        e.Jugadores.Add(j);
        return e;
      }
      return e;
    }
    public static bool operator ==(Equipo e, Jugador j)
    {
      return e.Jugadores.Contains(j) ? true : false;
    }
    public static bool ValidarEquipo(Equipo e)
    {
      if (e.DirectorTecnico is null &&e.Jugadores.Count()!=cantidadMaximaJugadores)
        return false;
      bool flag=false;
      int i = 1;
      do
      {
        foreach (Jugador jugador in e.Jugadores)
        {
          int aux = (int)(jugador.Posicion);
          if (aux == i)
          {
            i++;
            flag = true;
          }
        }
      } while (flag);
      return i == 4 ? true : false;
    }
  }
}
