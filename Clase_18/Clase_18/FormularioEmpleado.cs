using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_18
{
    public partial class FormularioEmpleado : Form,IGrafica
    {
        private string path = Environment.GetFolderPath()

        public FormularioEmpleado()
        {
            InitializeComponent();
        }

        private void FormularioEmpleado_Load(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado("Jorge", "Martínez", "123-456", EPuestoJerarquico.Sistemas, 15000);
            empleado.Mostrar(this);
        }



        public void MostrarEnGUI(string datos)
        {
            rtxtEmpleado.Text = datos;
        }


        public bool EscribirTxt(string path, Empleado emp)
        {
           
        }


        private void rtxttEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
