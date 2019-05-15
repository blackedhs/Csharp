using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        /// <summary>
        /// enum para clasificar la distribucion del teclado
        /// </summary>
        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }

        private EDistribucion distribucion;
        /// <summary>
        /// muestra todos los atributos del teclado
        /// </summary>
        /// <returns>string con todos los datos</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();            
            sb.Append((string)(Periferico)this);        
            sb.AppendLine("Distribucion: " + this.distribucion);
            return sb.ToString();
        }
        /// <summary>
        /// constructor de instancia de un teclado(distribucion por defecto Dvorak)
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="modelo">modelo</param>
        /// <param name="conector">tipo de conector</param>
        public Teclado(string marca, string modelo, Econector conector) : base(marca, modelo, conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }
        /// <summary>
        /// constructor de instancia de un teclado
        /// </summary>
        /// <param name="marca">marca</param>
        /// <param name="modelo">modelo</param>
        /// <param name="conector">tipo de conector</param>
        /// <param name="distribucion">distribucion del teclado</param>
        public Teclado(string marca, string modelo, Econector conector,EDistribucion distribucion) : base(marca, modelo, conector)
        {
            this.distribucion = distribucion;
        }
        /// <summary>
        /// compara q la distrbucion de un teclado sea distinta a la ingresada x param
        /// </summary>
        /// <param name="t">objeto teclado</param>
        /// <param name="distribucion">tipo de distribucion</param>
        /// <returns></returns>
        public static bool operator !=(Teclado t, EDistribucion distribucion)
        {
            return !(t==distribucion);
        }
        /// <summary>
        /// compara q la distrbucion de un teclado sea igual a la ingresada x param
        /// </summary>
        /// <param name="t">objeto teclado</param>
        /// <param name="distribucion">tipo de distribucion</param>
        /// <returns></returns>
        public static bool operator ==(Teclado t, EDistribucion distribucion)
        {
            return t.distribucion == distribucion;
        }
    }
}
