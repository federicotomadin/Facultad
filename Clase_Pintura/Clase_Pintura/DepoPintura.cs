using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
   public  class DepoPintura
    {
      private List<Pintura> _Lista;
      private int _cantMax;


   

      public DepoPintura(int canti)
      {
          _Lista = new List<Pintura>();
          this._cantMax = canti;
      }

       

      public static bool operator ==(DepoPintura pintura, Pintura pint)
      {
          foreach (Pintura item in pintura._Lista)
          {
              if (item == pint) return true;
          }
          return false;
      }

      public static bool operator !=(DepoPintura pintura, Pintura pint)
      {
          return !(pintura == pint);
      }



      public static bool operator +(DepoPintura pintura, Pintura pint)
      {

          foreach (Pintura item in pintura._Lista)
          {
              if (item == pint || pintura._Lista.Count >= pintura._cantMax)
                  return false;
 
          }
          pintura._Lista.Add(pint);
          return true;
 
      }


      public bool Agregar(Pintura pintura)
      {
          if (this + pintura)
              return true;

          else return false;
      }


      public bool EstaEnElDeposito(Pintura pintura)
      {
          if (this == pintura)
              return true;

          else return false;
      }


      public override string ToString()
      {
          StringBuilder sb = new StringBuilder();

          foreach (Pintura item in this._Lista)
          {
              sb.AppendLine("Marca  " + ((Pintura)item).Cantidad.ToString());
              
                        
 
          }
          return sb.ToString();

      }








    }
}
