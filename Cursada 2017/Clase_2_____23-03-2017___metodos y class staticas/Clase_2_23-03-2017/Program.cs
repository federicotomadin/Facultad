using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2_23_03_2017
{
  public   class Program
    {
        static void Main(string[] args)
        {

            Sello.mensaje = "Hola";

           Console.WriteLine( Sello.Imprimir());

            Sello.Borrar();


            Console.WriteLine(Sello.Imprimir());

            Console.ReadKey();




            Console.BackgroundColor = Sello.color;
            Sello.mensaje = "Hola";
            
            Console.WriteLine(Sello.ImprimirEnColor());

            Console.ReadLine();


            Console.WriteLine(Sello.ImprimirSello());


            Console.ReadLine();




        }
    }
}
