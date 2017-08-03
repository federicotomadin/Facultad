using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public abstract  class Local
    {
        private string _direccion;
       


        public Local()
        { }

        public Local(string direccion)
        {
            this._direccion = direccion;
           
        }

       public  abstract int AnchoDeFrente
        {
            get; 
            set; 
        }



   public override string ToString()
   {
       StringBuilder sBuilder = new StringBuilder();

       sBuilder.AppendLine(this._direccion);
      

       return sBuilder.ToString();
   }


   protected  int AnchoDeFrenteValidacion(int numero)
   {

       if (numero < 0 || numero % 2 != 0)
       {
           throw new Excepciones.NoGuardaException();
       }
       else return numero;
           

   }




   
    }
}
