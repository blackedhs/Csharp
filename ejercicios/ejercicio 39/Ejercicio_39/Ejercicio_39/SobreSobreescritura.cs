using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_39
{
  class SobreSobreescritura : Sobreescrito
  {
    public override string MiPropiedad
    {
      get {return  this.miAtributo; }
    }
  }
}
