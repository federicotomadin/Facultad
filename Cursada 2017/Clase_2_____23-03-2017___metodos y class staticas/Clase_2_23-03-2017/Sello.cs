using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_23_03_2017
{
  public static class Sello
    {

      public static string mensaje;

      public static ConsoleColor color;



      public static string Imprimir()
      {


          return Sello.mensaje;
 
      }


      public static void Borrar()
      {
          mensaje = null;
 
      }


      public static string ImprimirEnColor()
      {
          Console.BackgroundColor = ConsoleColor.Blue;

          return mensaje;
        
      }

      private static string ArmarMensaje()
      {
          StringBuilder sb = new StringBuilder();

          for (int i = 0; i < mensaje.Length+2; i++)
          {
              sb.Append("*");

          }

          sb.AppendLine("");

          sb.AppendLine("*" + mensaje + "*");




          for (int i = 0; i < mensaje.Length+2; i++)
          {
              sb.Append("*");

          }

          return sb.ToString();
      }


      public static string ImprimirSello()
      {
          return Sello.ArmarMensaje();
      }



    }
}
