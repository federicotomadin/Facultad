using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using Clase_19;


namespace Program_clase_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado e1 = new Empleado("José", "Pérez", "000-001", EPuestoJerarquico.Gerencia, 45000);

            Console.WriteLine("XML");
            XML<Empleado> xml = new XML<Empleado>();

            try
            {
                xml.guardar("", e1);
            }
            catch (Exception e)
            {
                throw new Excepciones();
            }



           Empleado e2;
            if (!xml.leer("Empleado.xml", out e2))
                Console.WriteLine("Error al leer XML");
            else
                Console.WriteLine(e2.ToString());

            Console.WriteLine("<----------------->");
            Console.ReadKey();


            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("TXT");
            Texto txt = new Texto();
            if (!txt.guardar("C:\\Empleado.txt", e1.ToString()))
                Console.WriteLine("Error al guardar TXT");

            string datos;
            if (!txt.leer("C:\\Empleado.txt", out datos))
                Console.WriteLine("Error al leer TXT");
            else
                Console.WriteLine(datos);

            Console.WriteLine("<----------------->");
            Console.ReadKey();

        }
    }
}
