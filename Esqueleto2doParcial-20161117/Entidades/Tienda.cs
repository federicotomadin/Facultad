using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Excepciones;


namespace Entidades
{
    [Serializable]
    [XmlInclude(typeof(Tienda))]

   

    public  class Tienda:Local
    {
      
        private string _nombre;
        private  int _anchoDeFrente;
       

       public Tienda()
        { }

        public Tienda(string nombre, int anchoDeFrente, string direccion)
            :base(direccion)
        {
            this.AnchoDeFrente = anchoDeFrente;
            this._nombre = nombre;
          
        }

      

        public static string ExponerDatos(Tienda tienda)
        {
            StringBuilder sBuilder = new StringBuilder();

           
           
            sBuilder.AppendLine("Ancho de Frente " + tienda.AnchoDeFrente);
            sBuilder.AppendLine("NOMBRE: " + tienda._nombre);
            sBuilder.AppendLine("DIRECCION: " + ((Local)tienda).ToString());
          
            sBuilder.AppendLine("<------------------------------->");
            return sBuilder.ToString();
        }




        public static bool GuardarTexto(Tienda tienda)
        {
            bool flag = false;
            Texto1 text = new Texto1();

            try
            {                              
                text.guardar("E:\\Archivo.txt",Tienda.ExponerDatos(tienda));
                flag = true;

            }
            catch (Exception e)
            {

                throw new NoGuardaException(e.Message, e);


            }

            return flag;
        }

        public static string LeerTexto()
        {
            string datos;

            Texto1 text = new Texto1();

            try
            {
                text.leer("E:\\Archivo.txt",out datos);
                return datos;
            }
            catch (Exception e)
            {
                throw e;
            }
        }



        public  bool Guardar(Tienda tienda)
        {
            bool flag = false;

            try
            {
                Xml<Tienda> ser = new Xml<Tienda>();
                ser.guardar("E:\\Archivo.xml", tienda);
                flag= true;

            }
            catch (Exception e)
            {

                throw new NoGuardaException(e.Message, e);
                

            }

            return flag;
        }

        public static bool  Leer(out Tienda aux )
        {
            bool flag = false;
             Xml<Tienda> ser = new Xml<Tienda>();
            try
            {
                            
                ser.leer("E:\\Archivo.xml", out aux);
                flag = true;            

            }
            catch (Exception )
            {
                throw new NoLeeException();
                                             
            }
            return flag;
        }

     

       public  override int AnchoDeFrente
        {
            get {return _anchoDeFrente; }
            set { _anchoDeFrente = this.AnchoDeFrenteValidacion(value); }
        }


 
         


     


   

    }
}
