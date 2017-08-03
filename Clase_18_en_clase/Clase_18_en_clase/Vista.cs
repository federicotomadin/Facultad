using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;
using System.IO;


namespace Clase_18_en_clase
{
   public class Vista:IGrafica
    {

    

        public void Main(string[] args)
        {
            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", Empleado.EPuestoJerarquico.Sistemas, 15000);
            empleado.Mostrar(this);

            Console.ReadKey();
        }

        #region IGrafica Members

        public void MostrarEnGUI(string datos)
        {
            Console.WriteLine(datos);
        }


       public bool EscribirTxt(string path, Empleado emp)
        {
            StreamWriter sw = null;

            try
            {
                sw = new StreamWriter(path);
                sw.WriteLine(emp.ToString());

                return true;


            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ERROR " + e.Message);
                return false;
 
            }
       

            catch (Exception e)
            {

                Console.WriteLine("ERROR " + e.Message);
                return false;

            }
        
 
        }

        #endregion
    }
}
