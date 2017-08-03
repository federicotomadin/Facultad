using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Centralita2 Centralita = new Centralita2("Telefonica");

            Local local1 = new Local("5545545", "4545454", 30f, 2.65f);
            Provincial provincia1 = new Provincial("5545545", "4545454", 30f, Franja.Franja_1);
            Local local2 = new Local("5545545", "4545454", 45f, 1.99f);
            Provincial provincia2 = new Provincial(Franja.Franja_3,provincia1);



            Centralita.Llamadas.Add(local1);
            Centralita.Mostrar();
            Console.ReadLine();
         
                             
            Centralita.Llamadas.Add(provincia1);
            Centralita.Mostrar();
            Console.ReadLine();
           
            
            Centralita.Llamadas.Add(local2);
            Centralita.Mostrar();
            Console.ReadLine();
           
            Centralita.Llamadas.Add(provincia2);
            Centralita.Mostrar();
            Console.ReadLine();
            Console.ReadLine();

            
            Centralita.OrdenarLlamada();

            Centralita.Mostrar();
            Console.WriteLine();


            



        }
    }
}
