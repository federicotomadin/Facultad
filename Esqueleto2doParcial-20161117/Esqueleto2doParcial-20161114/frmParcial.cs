using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Excepciones;
using System.Threading;

namespace Esqueleto2doParcial_20161114
{
    public partial class frmParcial : Form
    {
        private Thread _hilo;
     
        public frmParcial()
        {
            InitializeComponent();
           

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

           
            try
            {


                this._hilo = new Thread(this.Save);
                
                _hilo.Start();
              
               
                
              
            }
            catch(Exception )
            {
                MessageBox.Show("No se puedo guardar el archivo");
                throw;
               
 
            }





           
           
        }

        private void frmParcial_Load(object sender, EventArgs e)
        {
           

        }

        private void btnLeer_Click(object sender, EventArgs e)
        {

            try
            {
                  this._hilo = new Thread(Leer);
                
                   _hilo.Start();
            }
            catch (Exception)
            {
                
                throw;
            }


        }



        public void Save()
        {
            try
            {
                Tienda tienda = new Tienda("Tienda 1", 2, "Callao 340");
                tienda.Guardar(tienda);
                MessageBox.Show("El archivo se guardo correctamente");


            }
            catch (Exception )
            {
                MessageBox.Show("ERROR ! no se guardo el archivo");
                throw;
 
            }
        }


    public void Leer()
    {
        string prueba;

     try 
	{
        Tienda tienda = new Tienda("Tienda 1", 2, "Callao 340"); 
        Tienda tienda1 = new Tienda();
        Tienda.Leer(out tienda1);
         MessageBox.Show(tienda1.ToString());
	}
	catch (Exception)
	{
		MessageBox.Show("ERROR ! No se puedo leer el archivo");
		throw;
	}
    }

 
        
    }
}
