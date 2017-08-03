using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;


namespace CentralitaSerializacion
{
   public class Centralita:ISerializable
    {
        
   
         private List<Llamada> _listaDeLlamadas;
        protected string _razonSocial;
        private string _ruta;


        public Centralita()
        {
            this._listaDeLlamadas=new List<Llamada>();
        }

        public Centralita(string razon):this()
        {
            this._razonSocial = razon;
        }

        public string RazonSocial
        {
            get { return _razonSocial; }
            set { _razonSocial = value; }
        }

        public string RutaDelArchivo
        {
            get { return _ruta; }
            set { _ruta = value; }
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
            if (!Object.ReferenceEquals(centra, null) && !Object.ReferenceEquals(nuevaLlamada, null))
            {
                foreach (Llamada item in centra._listaDeLlamadas)
                {
                    if (item.CostoLlamada == nuevaLlamada.CostoLlamada)
                        return true;

                }
            }
            return false;
        }

        public static bool operator !=(Centralita centra, Llamada nuevaLlamada)
        {
            return !(centra == nuevaLlamada);
        }

        public static Centralita operator +(Centralita centra, Llamada nuevaLlamada)
        {
            if (centra == nuevaLlamada)
            {
                Console.WriteLine("La llamada ya se encuentra registrada");
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

            sb.AppendLine("Razon Social:  " + this._razonSocial + "\n");
            sb.AppendLine("Ganancia por Local:  " + this.GananciaPorLocal + "\n");
            sb.AppendLine("Ganancia por Provincia:  " + this.GananciaPorProvincial + "\n");
            sb.AppendLine("Ganancia Total:  " + this.GananciaTotal + "\n");

            sb.AppendLine("--------------------------------------------------------------------");
            sb.AppendLine("--------------------------------------------------------------------");
            sb.AppendLine("");

            foreach (Llamada item in _listaDeLlamadas)
            {
                if (item is Local)
                {
                  sb.AppendLine(((Local)item).ToString());

                }
                else if (item is Provincial)
                {
                    sb.AppendLine(((Provincial)item).ToString());

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
            try
            {
                this._listaDeLlamadas.Add(llam);


            }
            catch (Exception)
            {
                
                throw;
            }
           
        }

   
        public bool Serializarse( object obj)
        {
            

            try
            {
               
          
                using (XmlTextWriter xArchivo = new XmlTextWriter(this.RutaDelArchivo, Encoding.UTF8))
                {
                    XmlSerializer serializado = new XmlSerializer(typeof(Centralita));
                    serializado.Serialize(xArchivo, obj);
                    
                }
                return true;
              

            }
            catch (CentralitaException e)
            {
              
                throw new CentralitaException(e.Message,"Clase Centralita","Metodo Serializar",e);
           }
          
        }

        public bool DeSerializarse()
        {
            Centralita datos=new Centralita();
            try
            {
                using (XmlTextReader deserializar = new XmlTextReader(this.RutaDelArchivo))
                {
                    XmlSerializer deser = new XmlSerializer(typeof(Centralita));

                    datos = (Centralita)deser.Deserialize(deserializar);
                }

                return true;
            }
            catch (Exception e)
            {

                throw new CentralitaException(e.Message, "Clase Centralita", "Metodo Serializar", e);
            }
 
        }


        #endregion
    }
}
