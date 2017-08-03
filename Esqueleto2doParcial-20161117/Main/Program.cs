using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esqueleto2doParcial_20161114;
using Entidades;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {

            Tienda tienda = new Tienda("federico", 20, "tomadin");
            tienda.setAnchoDeFrente(188);

            try
            {
                Tienda.GuardarTexto(tienda);
                Console.WriteLine("El archivo se guardo con exito ");
            }
            catch (Exception e )
            {

                Console.WriteLine("El archivo no pudo ser guardado " + e.Message);
            }

            Console.ReadLine();


            Console.WriteLine(Tienda.LeerTexto());

            try
            {

                
                Console.WriteLine(Tienda.ExponerDatos(tienda));

            }

            catch (Exception e)
            {
                Console.WriteLine("no se pudo guardar el archivo");
            
            }
            Console.ReadLine();





          

            Console.WriteLine(Tienda.ExponerDatos(tienda));
              
            

     

            Console.ReadLine();






        }
    }
}
