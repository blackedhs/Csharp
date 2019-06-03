using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EmisorDeEmails : Emisor
    {
        private string email;
        private bool enviado;
        public EmisorDeEmails(string mensaje,EProducto producto,string email) : base(mensaje, producto)
        {
            this.email = email;
            this.enviado = false;
        }
        public override string EnviarMensaje()
        {
            StringBuilder sb = new StringBuilder();   
            sb.AppendLine((string)this);
            if (this.enviado == false)
            {
                sb.AppendFormat("\n.Se envia el mensaje");
                this.enviado = true;
            }
            else
                sb.AppendFormat(".Error,el mensaje ya fue enviado");
            return sb.ToString();
        }
        public static explicit operator string(EmisorDeEmails emisor)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(emisor.ToString());
            sb.AppendLine("\n." + emisor.email);
            return sb.ToString();
        }
    }
}
