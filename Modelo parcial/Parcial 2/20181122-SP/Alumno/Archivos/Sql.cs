using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Archivos
{
  public class Sql : IArchivo<Queue<Patente>>
  {
    private SqlCommand comando;
    private SqlConnection conexion;

    public void Guardar(string tabla, Queue<Patente> datos)
    {
      try
      {
        datos = new Queue<Patente>();


        conexion.Open();
        foreach (Patente patente in datos)
        {
          string query = $"INSERT INTO codPantente = {patente.CodigoPatente} tipoCodigo = " +
             $"{patente.TipoCodigo.ToString()} FROM {tabla}";
          comando = new SqlCommand(query, this.conexion);
          if (comando.ExecuteNonQuery() > 0)
          {
            //Todo piola
          }
        }
      }
      catch (Exception e)
      {
        throw e;
      }
      finally
      {
        conexion.Close();
      }

    }
    public void Leer(string tabla, out Queue<Patente> datos)
    {
      try
      {
        datos = new Queue<Patente>();
        Patente.Tipo tipo;

        comando.CommandText = "SELECT codPatente, tipoCodigo FROM Patente";
        conexion.Open();
        SqlDataReader dataReader = comando.ExecuteReader();
        while (dataReader.Read())
        {
          if (Enum.TryParse(dataReader["tipoCodigo"].ToString(), out tipo))
          {
            datos.Enqueue(new Patente(dataReader["codPatente"].ToString(), tipo));
          }
        }
      }
      catch
      {
        throw;
      }
      finally
      {
        conexion.Close();
      }
    }

    public Sql()
    {
      this.conexion = new SqlConnection(Properties.Settings.Default.TUVIEJA);
      comando = new SqlCommand
      {
        Connection = this.conexion
      };
    }
  }
}
