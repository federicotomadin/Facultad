using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_guia
{
    class Program
    { 
        
        private static List<int> _enteros=new List<int>();



        static void Main(string[] args)
        {

            int numeroSumar = 0;

            Console.Title = "Suma de enteros";


            do
            {
                Console.WriteLine("Ingrese el numero a sumar");

                numeroSumar = int.Parse(Console.ReadLine());
                Program._enteros.Add(numeroSumar);

                Console.WriteLine("Desea seguir con la operacion?  ingrese S o N");

                ValidarRespuesta.opcion = Console.ReadLine();

            } while (ValidarRespuesta.ValidaS_N());



        }
    }
}
