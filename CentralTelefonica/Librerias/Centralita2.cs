using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
   public class Centralita2
    {
        private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;


        public Centralita2()
        {
            this._listaDeLlamadas=new List<Llamada>();
        }

        public Centralita2(string razon):this()
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

        public void Mostrar()

        {
            StringBuilder sb=new StringBuilder();

            sb.Append("Razon Social:  " + this._razonSocial + "\n");
            sb.Append("Ganancia por Local:  " + this.GananciaPorLocal + "\n");
            sb.Append("Ganancia por Provincia:  " + this.GananciaPorProvincial + "\n");
            sb.Append("Ganancia Total:  " + this.GananciaTotal + "\n");

            Console.WriteLine(sb.ToString());

            foreach(Llamada item in _listaDeLlamadas)
            {
                if(item is Local)
                {
                    ((Local)item).Mostrar();
                   
                }
                else  if(item is Provincial)
                {
                    ((Provincial)item).Mostrar();
                   
                }
            }

              

            }

        public void OrdenarLlamada()
        {

            this._listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);            
 
        }


        #endregion

    }
}
