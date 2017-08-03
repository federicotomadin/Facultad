using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
  public  class Auto
    {
      private string _marca;
      private string _color;


      public Auto(string marc, string col)
      {
          this._marca = marc;
          this._color = col;
      }


      public string Marca
      {
          get { return _marca; }

      }

       public string Color
      {
          get { return _color; }
         
      }


       public static bool operator ==(Auto auto1, Auto auto2)
       {
           if (auto1._marca == auto2._marca && auto1._color == auto2._color)
               return true;

           else return false;
       }

       public static bool operator !=(Auto auto1, Auto auto2)
       {
           return !(auto1 == auto2);
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("La marca del auto es:  " + this._marca);

           sb.AppendLine("El Color del auto es   " + this._color);
         

           return sb.ToString();
       }

       public override bool Equals(Object obj)
       {
           if (obj is Auto && (Auto)obj == this)

               return true;

           else return false;
          
       }
        

    }
}
