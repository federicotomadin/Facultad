using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    [Serializable]
   public class Local:Llamada
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

        public Local(Llamada unaLlamada, float costo)
            : this(unaLlamada.NroDestino, unaLlamada.NroOrigen, unaLlamada.Duracion, costo)
        {

        }




        #endregion

        #region Sobreescritura de metodos

        public override bool Equals(Object obj)
        {
            if (obj is Local)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Mostrar();

        }

        #endregion



        #region Metodos

        public override float CostoLlamada
        {
            get { return this._costo * base.Duracion; }

        }


        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();

            sb.AppendLine("Costo por llamada local:   " + this.CostoLlamada);
          

            return sb.ToString();

        }



        private float CalcularCosto()
        {
            return this.Duracion * this.CostoLlamada;
        }




        #endregion
    }
}
