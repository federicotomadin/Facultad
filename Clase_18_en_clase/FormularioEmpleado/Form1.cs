using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Librerias;
using System.IO;

namespace FormularioEmpleado
{
    public partial class Form1 : Form,IGrafica
    {
        public Form1()
        {
            InitializeComponent();
           string path=txtPath.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", Empleado.EPuestoJerarquico.Sistemas, 15000);
            empleado.Mostrar(this);
            
        }
        

        public void MostrarEnGUI(string datos)
        {
            rtxtEmpleado.Text = datos;
        }

      

        public bool EscribirTxt(string path, Empleado emp)
        {
            StreamWriter sw = null;
          

            try
            {
                sw = new StreamWriter(path);
                sw.WriteLine(emp.ToString());
                MessageBox.Show("Se cargo correctamente", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;


            }
            catch (ArgumentException e)
            {
                Console.WriteLine("ERROR " + e.Message);
                MessageBox.Show("Ruta invalida", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
                return false;

            }


            catch (Exception e)
            {

                Console.WriteLine("ERROR " + e.Message);
                MessageBox.Show("Ruta invalida", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                return false;

            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
           //EscribirTxt(txtPath.Text, Empleado.);

            
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }
               
       
          
        /*    StreamWriter sw = null;
          

            try
            {
                sw = new StreamWriter(txtPath.);
                sw.WriteLine(rtxtEmpleado.Text);
                MessageBox.Show("Se cargo correctamente", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

              


            }
            catch (ArgumentException)
            {

                MessageBox.Show("Ruta invalida", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            

            }


            catch (Exception)
            {

                MessageBox.Show("Ruta invalida", "Formulario Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }*/
        
        
    
    }
}
