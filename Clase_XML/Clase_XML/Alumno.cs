using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas
{
  public  class Alumno:Persona
    {

      private float _nota;
      private string _legajo;

       public Alumno(string nombre, string apellido, long dni,float nota, string legajo)
           :base(nombre,apellido,dni)

        {
            this._nota = nota;
            this._legajo = legajo;
        }


       public static void MostrarAlumno(Alumno p)
       {
           
           Console.WriteLine(p.ToString());
          
       }


       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();

           sb.AppendLine(base.ToString());
           sb.AppendLine("Legajo " + this._legajo);
           sb.AppendLine("Nota " + this._nota);
           sb.AppendLine();
           return sb.ToString();


       }



    }
}
