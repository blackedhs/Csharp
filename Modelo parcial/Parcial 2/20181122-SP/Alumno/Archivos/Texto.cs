using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
  public class Texto : IArchivo<Queue<Patente>>
  {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      StreamWriter sw = new StreamWriter(archivo, true);
      try
      {
        foreach (Patente patente in datos)
        {
          sw.Write(patente.ToString());          
        }
      }
      catch (Exception)
      {
        
        throw;
      }
      finally
      {
        sw.Close();
      }
    }

    public void Leer(string archivo, out Queue<Patente> datos)
    {
      StreamReader sr = new StreamReader(archivo, true);
      try
      {        
        datos = new Queue<Patente>();
        string lectura;
        while((lectura =sr.ReadLine()) != null)
        {
           datos.Enqueue(new Patente(lectura, Patente.Tipo.Mercosur));
        }
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        sr.Close();
      }
    }
  }
}
