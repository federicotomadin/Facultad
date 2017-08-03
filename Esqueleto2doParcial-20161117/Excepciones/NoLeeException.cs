using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
  public  class NoLeeException:Exception
    {
      string mensaje = "No se puede leer el archivo";

      public NoLeeException()
          : base("ERROR: No puede leer el archivo")
      { }


      public NoLeeException(string mensaje)
          : base(mensaje)
      { }



    }
}
