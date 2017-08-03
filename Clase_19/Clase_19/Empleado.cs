using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_19
{
   public class Empleado:Persona
    {

        string _legajo;
        EPuestoJerarquico _puesto;
        int _salario;

        public Empleado() { }

        public string Legajo
        {
            get
            {
                return this._legajo;
            }
            set
            {
                this._legajo = value;
            }
        }
        public int Salario
        {
            get
            {
                return this._salario;
            }
            set
            {
                this._salario = value;
            }
        }

        public Empleado(string nombre, string apellido, string legajo, EPuestoJerarquico puesto, int salario)
            : base(nombre, apellido)
        {
            this._legajo = legajo;
            this._puesto = puesto;
            this._salario = salario;
        }

        public Empleado(Persona persona, string legajo, EPuestoJerarquico puesto, int salario)
            : this(persona.Nombre, persona.Apellido, legajo, puesto, salario)
        {
        }

        public override string PosicionSocietaria()
        {
           return "Empleado de " +  this._puesto.ToString();
        }


        public static bool operator ==(Empleado e1, Empleado e2)
        {
           
            {
                if (e1._legajo == e2._legajo)
                    return true;
            }
            return false;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(Persona.Mostrar(this));
            sb.AppendLine("Legajo  : " + this._legajo);
            sb.AppendLine(this.PosicionSocietaria()); //"Puesto  : " + this._puesto.ToString());
            sb.AppendLine("Salario : $" + this._salario);
            sb.AppendLine("******************");

            return sb.ToString();
        }


        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
