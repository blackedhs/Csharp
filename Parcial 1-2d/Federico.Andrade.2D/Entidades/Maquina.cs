using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        private List<Periferico> perifericos;
        /// <summary>
        /// retorna un string con toda la info de la maquina mas  los perificos conectados 
        /// </summary>
        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Nombre Maquina:" + Nombre);
                sb.AppendLine("Cantidad Max Perifericos:" + CantidadMaxPerifericos);
                foreach (Periferico periferico in this.perifericos)
                {
                    sb.AppendLine((string)periferico);
                }
                return sb.ToString();
            }
        }
        /// <summary>
        /// permite acceder a la propidad nombre de lectura y escritura 
        /// </summary>
        public  string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        /// <summary>
        /// constructor del objeto maquina privado que inicializa la cantidad maxima en 3 y la lista de perifericos
        /// </summary>
        private Maquina()
        {
            perifericos = new List<Periferico>();
            CantidadMaxPerifericos = 3;
        }
        /// <summary>
        /// constructor de instancia de maquina que llama al constructor privado y setea el atributo nombre
        /// </summary>
        /// <param name="nombre"></param>
        public Maquina(string nombre) : this()
        {
            Nombre = nombre;
        }
        /// <summary>
        /// permite acceder a la propidad CantidadeMaxPrefericos de lectura y escritura 
        /// </summary>
        public int CantidadMaxPerifericos
        {
            get { return cantidadMaxPerifericos; }
            set { cantidadMaxPerifericos = value; }
        }
        /// <summary>
        /// evalua si un periferico ya esta conectado en maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns>true verdadero -false falso</returns>
        public static bool operator ==(Maquina m, Periferico p)
        {
            foreach (Periferico periferico in m.perifericos)
            {
                if (periferico == p)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// evalua si un periferico no esta conectado en maquina
        /// </summary>
        /// <param name="m"></param>
        /// <param name="p"></param>
        /// <returns>False verdadero -true falso</returns>
        public static bool operator !=(Maquina m, Periferico p)
        {
            foreach (Periferico periferico in m.perifericos)
            {
                if (periferico == p)
                    return false;
            }
            return true;
        }

        public static string operator +(Maquina m, Periferico p)
        {
            if(m!=p && m.perifericos.Count()<m.CantidadMaxPerifericos )
            {
                m.perifericos.Add(p);
                return "Periferico Conectado";
            }
            return "No se Puede Conectar el dispositivo";
        }
        public static string operator -(Maquina m, Periferico p)
        {
            if (m == p )
            {
                m.perifericos.Remove(p);
                return "Periferico Desconectado";
            }
            return "No se Puede Desconectar el dispositivo";
        }

    }
}
