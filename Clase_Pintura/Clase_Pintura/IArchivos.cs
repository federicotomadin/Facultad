using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
  public  interface IArchivos<T>
    {
      bool guardar( T datos);
      bool leer( out T datos);
    }
}
