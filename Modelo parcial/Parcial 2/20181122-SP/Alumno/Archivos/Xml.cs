using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
namespace Archivos
{
  public class Xml<T> : IArchivo<T>
  {
    public void Guardar(string archivo, T datos)
    {
      XmlTextWriter xml = new XmlTextWriter(archivo,UTF8Encoding.UTF8);
      XmlSerializer ser = new XmlSerializer(typeof(T));
      try
      {
        ser.Serialize(xml, datos);
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        xml.Close();
      }
    }

    public void Leer(string archivo, out T datos)
    {
      XmlTextReader xml = new XmlTextReader(archivo);
      XmlSerializer ser = new XmlSerializer(typeof(T));
      try
      {
        datos = (T)ser.Deserialize(xml);
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        xml.Close();
      }
    }
  }
}
