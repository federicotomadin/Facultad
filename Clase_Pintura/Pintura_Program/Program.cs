using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_Pintura;

namespace Pintura_Program
{
    class Program
    {

        static void Main(string[] args)
        {
            DepoPintura deposito=new DepoPintura(4);
            DepoAuto depoauto = new DepoAuto(2);


            Deposito<Pintura> dp = new Deposito<Pintura>(4);
            Deposito<Auto> da = new Deposito<Auto>(3);



            Pintura p1=new Pintura(50);
            Pintura p2=new Pintura(60);
            Pintura p3=new Pintura(70);
            Pintura p4=new Pintura(80);
            Pintura p5 = new Pintura(90);

            Auto auto1 = new Auto("Renault", "rojo");
            Auto auto2 = new Auto("Clio", "Verde");

            da.Agregar(auto1);
            da.Agregar(auto2);



            dp.Agregar(p1);
            dp.Agregar(p2);
            dp.Agregar(p3);
            dp.Agregar(p4);
           

           Console.WriteLine(dp.ToString());

           Console.ReadLine();

           Console.WriteLine(da.ToString());


           Deposito<Pintura>.Guardar(da.ToString());



            Console.ReadLine();
        }
    }
}
