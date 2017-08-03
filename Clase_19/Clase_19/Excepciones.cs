using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19
{
   public class Excepciones:Exception
    {

       public Excepciones()
           : base("No se pudo guardar el archvio")
       { }
    }
}
