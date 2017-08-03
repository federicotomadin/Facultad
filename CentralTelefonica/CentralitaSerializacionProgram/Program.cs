using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CentralitaSerializacion;

namespace CentralitaSerializacionProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            Centralita centralita = new Centralita("Telefonica");

            Local local1 = new Local("5545545", "4545454", 30f, 2.65f);
            Provincial provincia1 = new Provincial("5545545", "4545454", 21f, Franja.Franja_1);
            Local local2 = new Local("5545545", "4545454", 45f, 1.99f);
            Provincial provincia2 = new Provincial(Franja.Franja_3, provincia1);

            centralita += local1;
            centralita += local2;
            centralita += provincia1;
            centralita += provincia2;
            Console.ReadLine();

            centralita += provincia1;
            Console.ReadLine();

            Console.WriteLine(centralita.ToString());
            Console.ReadLine();


            centralita.OrdenarLlamada();

            Console.WriteLine(centralita.ToString());
            Console.ReadLine();

        }
    }
}
