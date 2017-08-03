using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Clase_18;

namespace Consola_Ejercicio_8
{
    class Program
    {
        public class Vista : IGrafica
        {


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
             
            public bool Escribir.


            C:\Users\alumno\Desktop
        }
    }
}
