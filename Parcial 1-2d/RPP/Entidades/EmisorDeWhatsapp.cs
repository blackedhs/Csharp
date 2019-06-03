using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        private bool numeroCargado;
        private int numeroTelefono;

        /// <summary>
        /// carga un nuevo telefono y setear al numero cargado siempre y cuando este dentro de los parametros
        /// </summary>
        public int NumeroTelefono
        {
            get { return numeroTelefono; }
            set
            {                
                if(value>1500000000 && value< 1599999999)
                {
                    numeroCargado = true;
                    numeroTelefono = value;  
                }                    
            }
        }
        /// <summary>
        /// llama al constructor base y pone al numero cargado en false x defecto
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="producto"></param>
        public EmisorDeWhatsapp(string mensaje,EProducto producto) : base(mensaje, producto )
        {
            this.numeroCargado = false;
        }
        /// <summary>
        /// intenta enviar un msj.. devuelve un msj de si pudo o no..junto a los datos del msj
        /// </summary>
        /// <returns></returns>
        public override string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine((string)this);
            if (this.numeroCargado == true)
            {
                sb.AppendFormat("\n.Se envia el mensaje");
            }
            else
                sb.AppendFormat(".No se pudo enviar el mensaje");
            return sb.ToString();
        }
        /// <summary>
        /// devuelve los datos del msj
        /// </summary>
        /// <param name="emisor"></param>
        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(emisor.ToString());
            if (emisor.numeroCargado == false)
                sb.AppendLine("\n.No cargado");
            else
            {
                sb.AppendFormat("\n.{0}", emisor.numeroTelefono);
            }           
            return sb.ToString();
        }
    }
}
