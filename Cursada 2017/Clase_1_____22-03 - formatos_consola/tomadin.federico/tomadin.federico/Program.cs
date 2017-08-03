using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomadin.federico
{
    class Program
    {
        static void Main(string[] args)
        {
            //las variables escalares solo pueden contener un valor

            Console.Title = "Funciones matematicas";

            Console.WriteLine("Ingrese los 5 valores");
            int contador = 0;
            int var1, var2, var3, var4, var5;
             float promedio;
            int min=0;
            int max=0;



                Console.WriteLine("Ingrese el primer valor");
                Int32.TryParse(Console.ReadLine(), out var1);
                min = var1;
                max=var1;

                Console.WriteLine("Ingrese el primer valor");    
                Int32.TryParse(Console.ReadLine(), out var2);
                if (var2 < var1) min = var2;
                if(var2>max) max=var2;

                Console.WriteLine("Ingrese el primer valor");
                Int32.TryParse(Console.ReadLine(), out var3);
                if (var3 < min) min = var3;
                if(var3>max) max=var3;

                Console.WriteLine("Ingrese el primer valor"); 
                Int32.TryParse(Console.ReadLine(), out var4);
                if (var4 < min) min = var4;
                 if(var4>max) max=var4;

                Console.WriteLine("Ingrese el primer valor");
                Int32.TryParse(Console.ReadLine(), out var5);
                if (var5 < min) min = var5;
                 if(var5>max) max=var5;




            int aux = 0;

            Console.WriteLine("El menor valor es {0,10}",min);
            Console.WriteLine("El mayor valor es {0,10}", max);

            promedio=(var1+var2+var3+var4+var5)/5;
            Console.WriteLine("El promdio es{0,10}", promedio);

            Console.ReadLine();
              


            
            


        }
    }
}
