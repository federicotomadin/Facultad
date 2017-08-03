using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
   public class DepoAuto
    {
       private List<Auto> _Lista;
       private int _cantMax;

       public DepoAuto(int cantidad)
       {
           this._Lista = new List<Auto>();
           this._cantMax = cantidad;
       }


       public static bool operator ==(DepoAuto pintura, Auto pint)
       {
           foreach (Auto item in pintura._Lista)
           {
               if (item == pint) return true;
           }
           return false;
       }

       public static bool operator !=(DepoAuto pintura, Auto pint)
       {
           return !(pintura == pint);
       }



       public static bool operator +(DepoAuto pintura, Auto pint)
       {

           foreach (Auto item in pintura._Lista)
           {
               if (item == pint || pintura._Lista.Count >= pintura._cantMax)
                   return false;

           }
           pintura._Lista.Add(pint);
           return true;

       }


       public bool Agregar(Auto auto)
       {
           if (this + auto)
               return true;

           else return false;
       }


       public bool EstaEnElDeposito(Auto auto)
       {
           if (this == auto)
               return true;

           else return false;
       }


       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           foreach (Auto item in this._Lista)
           {
               sb.AppendLine("Marca  " + ((Auto)item).Marca.ToString());

               sb.AppendLine("Color  " + ((Auto)item).Color.ToString());
            


           }
           return sb.ToString();

       }
    }
}
