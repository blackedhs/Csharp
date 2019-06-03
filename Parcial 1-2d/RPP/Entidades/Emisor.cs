using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        public enum EProducto
        {
            SQLDatabase,
            MonitoringApp,
            AppHosting,
        }
        private string mensaje;
        private EProducto producto;
        /// <summary>
        /// constructor base
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="producto"></param>
        protected Emisor(string mensaje,EProducto producto)
        {
            this.mensaje = mensaje;
            this.producto = producto;
        }
        public abstract string EnviarMensaje();
        /// <summary>
        /// compara dos emisores por sus atributos
        /// </summary>
        /// <param name="emisor"></param>
        /// <param name="emisorDos"></param>
        /// <returns></returns>        
        public static bool operator ==(Emisor emisor,Emisor emisorDos)
        {
            return emisor.producto == emisorDos.producto && emisor.mensaje==emisorDos.mensaje;
        }
        /// <summary>
        /// compara dos emisores
        /// </summary>
        /// <param name="emisor"></param>
        /// <param name="emisorDos"></param>
        /// <returns></returns>
        public static bool operator !=(Emisor emisor, Emisor emisorDos)
        {
            return !(emisor == emisorDos);
        }
        /// <summary>
        /// muestra los atributos de un emisor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n.{0}\n.{1}", this.producto, this.mensaje);
            return sb.ToString();
        }
    }
}
