using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaSerializacion
{
    class CentralitaException :Exception
    {
        private string _nombreClase;
        private string _nombreMetodo;
        private Exception _exceptionInterna;


       

        public string NombreClase
        {
            get { return _nombreClase; }
            
        }

        public Exception ExcepcionInterna
        {
            get { return _exceptionInterna; }

        }

        public string NombreMetodo
        {
            get { return _nombreMetodo; }

        }
        


        public CentralitaException(string mensaje,string clase,string metodo)
            :base(mensaje)
            
        {
           
            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

        public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
            : base(mensaje, innerException)
        {

            this._nombreClase = clase;
            this._nombreMetodo = metodo;
        }

      

   
    
    }
}
