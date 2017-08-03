using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   

  public static  class Extension
    {
     

      public static int setAnchoDeFrente(this Tienda objeto,int ancho)
      {

         return  objeto.AnchoDeFrente = ancho;


         
      }
    }
}
