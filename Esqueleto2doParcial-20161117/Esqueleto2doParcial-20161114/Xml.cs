using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
using Excepciones;
using System.IO;
namespace Entidades
{
    public class Xml<T>:IArchivos<T>
    {

        public bool guardar(string archivo, T datos)
        {
            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter(archivo, UTF8Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(escritor, datos);
                    escritor.Close();
                    return true;
                }
            }
            catch (Exception e)
            {
                throw new NoGuardaException(e.Message);

                return false;

            }

        }


        public bool leer(string archivo, out T datos)
        {

            try
            {

                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(lector);
                    lector.Close();
                    return true;
                }
            }


            catch (Exception e)
            {
                throw new NoLeeException(e.Message);
                datos = default(T);
                return false;
            }
        }



    }
}
