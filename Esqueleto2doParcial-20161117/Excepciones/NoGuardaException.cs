using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
   public class NoGuardaException:Exception
    {
        string mensaje = "El archivo no pudo ser guardado";

        public  NoGuardaException()
            :base("El archivo no pudo ser guardado")
        {
          
 
        }


        public NoGuardaException(string mensaje)
            : base(mensaje)
        { }

        public NoGuardaException(string mensaje, Exception innerException)
            :base(mensaje,innerException)
        { }

    }
}
