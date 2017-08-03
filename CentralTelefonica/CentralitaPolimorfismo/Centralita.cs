using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaPolimorfismo
{
   public  class Centralita
    {
         private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;


        public Centralita()
        {
            this._listaDeLlamadas=new List<Llamada>();
        }

        public Centralita(string razon):this()
        {
            this._razonSocial = razon;
        }


        #region Propiedades

        public float GananciaPorLocal
        {
            get { return this.CalcularGanancia(TipoLlamada.Local); }
        }

        public float GananciaPorProvincial
        {
            get { return this.CalcularGanancia(TipoLlamada.Provincial); }
        }

        public float GananciaTotal
        {
            get { return this.CalcularGanancia(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this._listaDeLlamadas; }
        }


        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Centralita centra, Llamada nuevaLlamada)
        {
            foreach (Llamada item in centra._listaDeLlamadas)
            {
                if (item == nuevaLlamada)
                    return false;

            }
            return true;
        }

        public static bool operator !=(Centralita centra, Llamada nuevaLlamada)
        {
            return !(centra == nuevaLlamada);
        }

        public static Centralita operator +(Centralita centra, Llamada nuevaLlamada)
        {
            if (centra == nuevaLlamada)
            {
                Console.WriteLine("La llamada ya existe ingrese otra llamada");
                return centra;
            }
            else
            {
                centra.AgregarLlamada(nuevaLlamada);
                return centra;
            }
        }

        #endregion

        #region Metodos
        float resultadoLocal = 0;
        float resultadoProvincial = 0;
        float resultado = 0;

        public float CalcularGanancia(TipoLlamada tipo)
        {

           
          foreach(Llamada item in _listaDeLlamadas)
          {

            switch (tipo)
            {
                case TipoLlamada.Local:
                    
                 if (item is Local)
                    {
                        resultadoLocal += ((Local)item).CostoLlamada;

                    }                     
                    break;
                case TipoLlamada.Provincial:                               
                    if (item is Provincial)
                    {
                        resultadoProvincial += ((Provincial)item).CostoLlamada;
                    }                     
                    break;          
                case TipoLlamada.Todas:
                    resultado = resultadoLocal + resultadoProvincial;                     
                    break;                     

            }                     
           
        }

          
            

            if (tipo == TipoLlamada.Local)
            {
                resultado = resultadoLocal;
            }
            else if (tipo == TipoLlamada.Provincial)
            {
                resultado = resultadoProvincial;
            }
            else  if(tipo==TipoLlamada.Todas)
            {
                resultado = resultadoLocal + resultadoProvincial;
            }

            return resultado;
              
             
            }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Razon Social:  " + this._razonSocial);
            sb.AppendLine("Ganancia por Local:  " + this.GananciaPorLocal);
            sb.AppendLine("Ganancia por Provincia:  " + this.GananciaPorProvincial );
            sb.AppendLine("Ganancia Total:  " + this.GananciaTotal);

          

            foreach (Llamada item in _listaDeLlamadas)
            {
                if (item is Local)
                {
                    ((Local)item).ToString();

                }
                else if (item is Provincial)
                {
                    ((Provincial)item).ToString();

                }
            }

            return sb.ToString();
              

            }

        public void OrdenarLlamada()
        {

            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);            
 
        }

        private void AgregarLlamada(Llamada llam)
        {
            this._listaDeLlamadas.Add(llam);

        }


        #endregion
    }
}
