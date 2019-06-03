using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        private List<Emisor> emisores;
        private string region;
        /// <summary>
        /// Recorre su lista de msj y intenta enviarlos
        /// </summary>
        /// <returns></returns>
        public string EnviarMensajes()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("." + this.region);
            foreach (Emisor e in this.emisores)
            {
                sb.AppendLine(e.EnviarMensaje());
            }
            return sb.ToString();
        }
        /// <summary>
        /// inicializa la lista de msj
        /// </summary>
        private ManejadorDeEmisores()
        {
            emisores = new List<Emisor>();
        }
        /// <summary>
        /// setea la region y llama al constructor privado
        /// </summary>
        /// <param name="region"></param>
        public ManejadorDeEmisores(string region) : this()
        {
            this.region = region;
        }
        /// <summary>
        /// revisa si el manejador ya contiene un msj
        /// </summary>
        /// <param name="manejador"></param>
        /// <param name="emisor"></param>
        /// <returns></returns>
        public static bool operator ==(ManejadorDeEmisores manejador,Emisor emisor)
        {
            foreach (Emisor e in manejador.emisores)
            {
                if (e == emisor)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// revisa si el manejador no contiene un msj
        /// </summary>
        /// <param name="manejador"></param>
        /// <param name="emisor"></param>
        /// <returns></returns>
        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador == emisor);
        }
        /// <summary>
        /// revisa si el manejador no contiene un msj y lo agrega
        /// </summary>
        /// <param name="manejador"></param>
        /// <param name="emisor"></param>
        /// <returns></returns>
        public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor)
        {
            if (manejador != emisor)
            {
                manejador.emisores.Add(emisor);
                return true;
            }
            return false;
        }
        /// <summary>
        /// revisa si el manejador contiene un msj y lo quita
        /// </summary>
        /// <param name="manejador"></param>
        /// <param name="emisor"></param>
        /// <returns></returns>
        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            foreach (Emisor e in manejador.emisores)
            {
                if (e == emisor)
                {
                    manejador.emisores.Remove(e);
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// devuelve los datos del manejador y de todos sus msj
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("." + this.region);
            foreach (Emisor e in this.emisores)
            {
                sb.AppendLine(e.ToString());
            }
            return sb.ToString();
        }

    }
}
