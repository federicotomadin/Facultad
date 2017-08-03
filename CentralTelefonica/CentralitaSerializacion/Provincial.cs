using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
     [Serializable]
    public class Provincial: Llamada
    {
   
        protected Franja _franjaHoraria;



        public Provincial(string nrodestino, string nroOrigen, float duracion, Franja franja)
            : base(nrodestino, nroOrigen, duracion)
        {
            this._franjaHoraria = franja;
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            : this(unaLlamada.NroDestino, unaLlamada.NroOrigen, unaLlamada.Duracion,miFranja)
        {

        }

        #region Sobreescritura de metodos

        public override bool Equals(Object obj)
        {
            if (obj is Provincial)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return this.Mostrar();

        }

       
        
        #endregion




        public override float CostoLlamada
        {
            get { return this.CalcularCosto(); }

        }

        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            base.Mostrar();

            sb.AppendLine("Franja horaria:  " + this._franjaHoraria);
            sb.AppendLine("");
         
            sb.AppendLine("Costo por llamada provincial:   " + this.CostoLlamada);
          

          return sb.ToString();

        }


        private float CalcularCosto()
        {
            switch (this._franjaHoraria)
            {
                case Franja.Franja_1: return (float)(this.Duracion * 0.99);

                case Franja.Franja_2: return (float)(this.Duracion * 1.25);

                case Franja.Franja_3: return (float)(this.Duracion * 0.66);
                default: return 0;
            }
        }
    }
}
