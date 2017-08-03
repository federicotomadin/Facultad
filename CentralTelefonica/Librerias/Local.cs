using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Local : Llamada
    {
        protected float _costo;


        #region Constructores

        public Local()
        { }

        public Local(string nrodestino, string nroOrigen, float duracion, float costo)
            : base(nrodestino, nroOrigen, duracion)
        {
            this._costo = costo;
        }

        public Local(Llamada unaLlamada, float costo):this(unaLlamada.NroDestino,unaLlamada.NroOrigen,unaLlamada.Duracion,costo)
        {
           
        }

       


        #endregion 

        public  float CostoLlamada
        {
            get { return this._costo*base.Duracion; }

        }


        public override void Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();
         
            sb.Append("Costo por llamada local:   ");
            sb.Append(this.CostoLlamada);

           Console.WriteLine(sb.ToString());

        }

        #region Metodos

        private float CalcularCosto()
        {
            return this.Duracion * this.CostoLlamada;
        }

        


        #endregion


       
    }
    
}
