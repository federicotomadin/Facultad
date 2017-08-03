using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
   public class Provincial:Llamada
    {
      protected Franja _franjaHoraria;



      public Provincial(string nrodestino, string nroOrigen, float duracion, Franja franja)
          : base(nrodestino, nroOrigen, duracion)
      {
          this._franjaHoraria = franja;
      }

      public Provincial(Franja miFranja, Llamada unaLlamada):this(unaLlamada.NroDestino,unaLlamada.NroOrigen,unaLlamada.Duracion,miFranja)
      {
       
      }





       public  float CostoLlamada
       {
           get { return this.CalcularCosto(); }

       }

       public override void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           base.Mostrar();

           sb.Append("Costo por llamada provincial:   ");
           sb.Append(this.CostoLlamada);

           Console.WriteLine(sb.ToString());

       }


       private float  CalcularCosto()
       {
           switch (this._franjaHoraria)
           {
               case Franja.Franja_1: return (float)(this.Duracion * 0.99);
            
               case Franja.Franja_2: return (float)(this.Duracion * 1.25);

               case Franja.Franja_3: return (float)(this.Duracion * 0.66);
               default: return 0;
           }
       }


    }
}
