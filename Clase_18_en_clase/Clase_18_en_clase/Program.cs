using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;
using System.IO;

namespace Clase_18_en_clase
{
   public class Program
    {
        static void Main(string[] args)
        {
            Vista vista = new Vista();

           
            //vista.Main(args);
            
          

            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", Empleado.EPuestoJerarquico.Sistemas, 15000);

            string ruta="";

           if( vista.EscribirTxt(ruta,empleado))
           {
               Console.WriteLine("Se escribio correctamente el archivo");
           }

           Console.ReadLine();
            

          
           



        }
    }
}
