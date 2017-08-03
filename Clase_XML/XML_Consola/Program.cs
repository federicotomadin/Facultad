using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

using System.Xml;

namespace Personas
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumn = new Alumno("Federico", "Tomadin", 32191299,4f,"40404040");

            Console.WriteLine(alumn.ToString());

            Console.ReadLine();
           





            List < Persona> _listapersona= new List<Persona>();

            Persona persona = new Persona("Federico", "Tomadin", 30);

           Persona persona1 =new Persona ("Federico","Tomadin",30);
           Persona persona2 = new Persona("Lucas", "Goicochea", 28);
           Persona persona3 = new Persona("Martin", "Carrizo", 27);
           Alumno alumn1 = new Alumno("Lucas", "Pereyra", 3219, 4f, "40404040");
           Alumno alumn2 = new Alumno("Tincho", "Cacnona", 3299, 4f, "40404040");
           Alumno alumn3 = new Alumno("Checho", "Ibañez", 3299, 4f, "40404040");


           _listapersona.Add(persona1);
           _listapersona.Add(persona2);
           _listapersona.Add(persona3);
           _listapersona.Add(alumn1);
           _listapersona.Add(alumn2);
           _listapersona.Add(alumn3);

           XmlTextWriter writer;
           XmlSerializer ser;

           try
           {
               writer = new XmlTextWriter("E:\\ArchivoXml", UTF8Encoding.UTF8);

               ser = new XmlSerializer(typeof(Persona));
               ser.Serialize(writer, persona);
               writer.Close();
           }
           catch (Exception e)
           {
               Console.WriteLine(e.Message);
           }




            Persona aux = new Persona();

            XmlTextReader reader;


            try
            {
                reader = new XmlTextReader("E:\\ArchivoXml");
                ser = new XmlSerializer(typeof(Persona));
                aux = (Persona)ser.Deserialize(reader);

                Console.WriteLine(aux.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


//------------------------------------------------------------------------------





            try
            {
                writer = new XmlTextWriter("E:\\ArchivoXmlLista", UTF8Encoding.UTF8);

                ser = new XmlSerializer(typeof(List<Persona>));
                ser.Serialize(writer, _listapersona);
                writer.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }




            List<Persona> _aux = new List<Persona>();

            XmlTextReader reader2;


            try
            {
                reader2 = new XmlTextReader("E:\\ArchivoXmlLista");
                ser = new XmlSerializer(typeof(List<Persona>));
                _aux = (List<Persona>)ser.Deserialize(reader2);


                foreach (Persona item in _aux)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }









            Console.ReadLine();



        }
    }
}
