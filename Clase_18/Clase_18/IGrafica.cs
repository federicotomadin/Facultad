using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_18
{
    public interface IGrafica
    {
        void MostrarEnGUI(string mostrar);
        bool EscribirTxt(string path, Empleado e);
    
    }
}
