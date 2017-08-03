using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComprobandoGuardar()
        {

            //TEST QUE PRUEBA EL METODO GUARDAR

            Tienda tienda = new Tienda("54545", 40, "Callao 340");

            try 
	          {	        
                 if (!tienda.Guardar(tienda))
            
                   Assert.Fail("No se pudo guardar el archivo");
            
		
	             }
	          catch (Exception)
         	{
		
		       throw new Excepciones.NoGuardaException();
	          }
        
           
           


        }

          [TestMethod]
         public void TestMethod2()
        {
               Tienda tienda = new Tienda("Tienda 1", 40, "Callao 340");
            try
            {
               

                tienda.Guardar(tienda);
                Tienda.Leer(out tienda);

            }
            catch (Exception e)
            {
                Assert.IsFalse(tienda.Guardar(tienda), "No se puedo guardar el archivo");
            }
        }

            
            


        
    }
}
