using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;


namespace Clase_Pintura
{
   public  class Binarios:IArchivos<string>
    {
      

       public  bool guardar(string datos)
       {
           bool flag = false;

           try
           {

               using (StreamWriter sw = new StreamWriter("E:\\Deposito.txt", true,UTF8Encoding.UTF8))
               {

                   sw.Write(datos);
                  
               }
               flag = true;
           }


           catch (Exception e)
           {
               throw e;
           }

           return flag;

            
       }


       public  bool leer(out string datos)
       {

           bool flag = false;
          
           try
           {
               using (StreamReader sr = new StreamReader("E:\\Deposito.txt"))
               {

                   datos = sr.ReadToEnd();
                   
               }
               flag = true;
           }
          
           catch (Exception e)
           {
               throw e; 
               
           }

           return flag;

          
       }


    }
}
