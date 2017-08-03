using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
   public class Llamada
   {
       #region Atributos
       protected float _duracion;
       protected string _nroDestino;
       protected string _nroOrigen;
       #endregion

       #region Propiedades
      

       public float Duracion
       {
           get { return _duracion; }
          
       }

       public string NroDestino
       {
           get { return _nroDestino; }

       }

       public string NroOrigen
       {
           get { return _nroOrigen; }

       }

       #endregion

       #region Constructor

       public Llamada()
       { }

       public Llamada(string origen, string destino, float duracion)
       {                 
           this._nroOrigen = origen;
           this._nroDestino = destino;
           this._duracion = duracion;
       }

      #endregion 

       #region Metodos

       public virtual void Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.Append("Origen de la LLamada:  ");
           sb.Append(this._nroOrigen.ToString());
           sb.Append("\n");
           sb.Append("Destino de la llamada: ");
           sb.Append(this._nroDestino.ToString());
           sb.Append("\n");
           sb.Append("Duracion:  ");
           sb.Append(this._duracion.ToString());
           sb.Append("\n");

           Console.WriteLine(sb.ToString());
       
       }


       public float CostoLlamadas { get;  }

       public static int OrdenarPorDuracion(Llamada uno, Llamada dos)
       {
           int valor = 0;

           if (uno._duracion.CompareTo(dos._duracion) > 0)
           {
               valor = 1;
           }
           else if (uno._duracion.CompareTo(dos._duracion) < 0)
           {
               valor = -1;
           }

           return valor;

           

       }

       #endregion



   }
}
