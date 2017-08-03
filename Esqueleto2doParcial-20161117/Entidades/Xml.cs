using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;

namespace Entidades
{
    public class Xml<T>:IArchivos<T>
    {

        public bool guardar(string archivo, T datos)
        {
            bool flag = false;
            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter(archivo, UTF8Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(escritor, datos);
                    flag = true;
                }
            }
            catch (Exception e)
            {
                throw new NoGuardaException(e.Message);
            }

            return flag;

        }


        public bool leer(string archivo, out T datos)
        {
            bool flag = false;

            try
            {

                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(lector);
                    flag= true;
                }
            }


            catch (Exception e)
            {
                datos = default(T);

                throw new NoLeeException(e.Message);
                
            }

            return flag;
        }



    }
}
