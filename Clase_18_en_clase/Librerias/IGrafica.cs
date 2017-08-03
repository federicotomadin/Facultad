using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
   public interface IGrafica
    {
        void MostrarEnGUI(string datos);
        bool EscribirTxt(string path, Empleado e);
    }
}
