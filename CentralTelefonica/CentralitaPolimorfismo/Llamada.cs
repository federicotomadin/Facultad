using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
   public abstract class Llamada
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

       #region Sobrecarga de Operadores

       public static bool operator ==(Llamada uno, Llamada dos)
       {
           if (uno.Equals(dos) && uno._nroOrigen == dos._nroOrigen && uno._nroDestino == dos.NroDestino)
           {
               return true;
           }
           else return false;
 
       }

       public static bool operator !=(Llamada uno, Llamada dos)
       {
           return !(uno == dos);

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

       protected virtual string Mostrar()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine("Origen de la LLamada:  ");
           sb.AppendLine(this._nroOrigen.ToString());
           sb.AppendLine("\n");
           sb.AppendLine("Destino de la llamada: ");
           sb.AppendLine(this._nroDestino.ToString());
           sb.AppendLine("\n");
           sb.AppendLine("Duracion:  ");
           sb.AppendLine(this._duracion.ToString());
           sb.AppendLine("\n");

          return sb.ToString();
       
       }


       public abstract float CostoLlamada { get;  }

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
