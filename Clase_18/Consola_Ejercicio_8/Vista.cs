using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_18;
using System.IO;

namespace Consola_Ejercicio_8
{
   public class Vista : IGrafica
        {

       private string path;
       Environment.SpecialFolder;
    

        public void Main(string[] args)
            {

                Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", EPuestoJerarquico.Sistemas, 15000);
                empleado.Mostrar(this);

                Console.ReadKey();
            }

            public void MostrarEnGUI(string datos)
            {
                Console.WriteLine(datos);
            }


            public bool EscribirTxt(string path, Empleado emp)
            {


            }


            
        }
}
