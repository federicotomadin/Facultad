using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Clase_19
{
   public class  Texto:IArchivo<string>
    {
       public bool guardar(string archivo, string datos)
       {
           StreamWriter sw = null;
           try
           {
                sw = new StreamWriter(archivo, true,UTF8Encoding.UTF8);
               sw.WriteLine(datos);
               return true;
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
               return false;
           }

           finally
           {
               if (sw != null)
               {
                   sw.Close();
               }
           }
       }


         public bool leer(string archivo, out string datos)
        {

            StreamReader sr = null;
            try
            {
                sr = new StreamReader(archivo);
                datos = sr.ReadToEnd();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                datos = "";
                return false;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
 
            }






       }
    }
}
