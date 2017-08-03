using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_12_guia
{
    public class ValidarRespuesta
    {
        public static string opcion;



        public static bool ValidaS_N()
        {



            if (ValidarRespuesta.opcion == "S") return true;

            else if (opcion == "N") return false;

            else Console.WriteLine("Caracter no valido -- Vuelva a ingresar el caracter");

            return true;

        }

    }

   }
