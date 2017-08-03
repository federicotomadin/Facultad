using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercico_guia_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura = 0;
            int altura2 = 0;
            int asterisco = 0;
            
          

            Console.WriteLine("Ingrese la altura");

            Console.BackgroundColor = ConsoleColor.Blue;

          


            Int32.TryParse(Console.ReadLine(), out altura);
            altura2 = altura;
            Console.WriteLine();



            for (int i = 1; i < altura; i++)
            {

                for (int j = 0; j <altura-i ; j++)
                {

                    Console.Write(" ");
 
                }

                for (asterisco = 0; asterisco < (i * 2) - 1; asterisco++)

                {
                    Console.Write("*");
                }

                    Console.WriteLine();
           
            }

            

            Console.BackgroundColor = ConsoleColor.Black;
            
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadLine();
            

        }
    }
}
