using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
   public  class Pintura
    {
       private int _cantidad;

      
       public int Cantidad
       {
           get { return _cantidad; }
           set { _cantidad = value; }
       }

       public Pintura(int cant)
       {
           this._cantidad = cant;
       }

       public static bool operator ==(Pintura pintura1, Pintura pintura2)
       {
           if (pintura1._cantidad == pintura2._cantidad) return true;

           else return false;
          
       }

       public static bool operator !=(Pintura pintura1, Pintura pintura2)
       {
           return !(pintura1 == pintura2);

       }


       public override bool Equals(Object obj)
       {
           if (obj is Pintura)
               return true;
           else return false;
       }


       public override string ToString()
       {
           return this._cantidad.ToString();
       }
       

   
    }
}
