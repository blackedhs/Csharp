using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        private int ramMB;
        /// <summary>
        /// devuelve todos los valores de los atributos de la placavideo
        /// </summary>
        /// <returns>string con toda su info</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)(Periferico)this);
            sb.AppendLine("Ram Mb: " + this.ramMB);
            return sb.ToString();  
        }
        /// <summary>
        /// constructor de instancia de la placa
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="modelo">modelo</param>
        /// <param name="ramMB">memoria maxima</param>
        public PlacaVideo(string marca, string modelo, int ramMB): base(marca,modelo,Econector.PCIExpress)
        {
            this.ramMB = ramMB;
        }
    }
}
