using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Alumnos
{
    public class Persona
    {
        protected string _nombre;
        protected string _apellido;
        protected int _edad;
        protected ESexo _sexo;

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._edad = edad;
            this._sexo = sexo;
        }


       

        public string Nombre
        {
            get { return _nombre;}
        
        }


        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }

        }




        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("El Nombre es  " + this.Nombre);
            sb.AppendLine("El Apellido es  "  + this.Apellido);

            return sb.ToString();   
        }

           
        

         



    }
}
