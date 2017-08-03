using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
  public  class Texto1:IArchivos<string>
    {


        public  bool guardar(string archivo, string datos)
        {
            bool flag = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, false,UTF8Encoding.UTF8))
                {
                    sw.Write(datos);
                    flag = true;
                
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("No se puedo escribir el archivo  " + e.Message);
            }

            return flag;
        }


        public bool leer(string archivo,out string datos)
        {


            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {

                    datos = sr.ReadToEnd();


                }
                return true;

            }
            catch (Exception e)
            {

                throw e;
               
            }
          



         
        }
    }
}
