using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FrmPrincipal
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }


        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestDelegados delegado = new frmTestDelegados();
            delegado.ShowDialog();

            //frmTestDelegados testDelegados = new frmTestDelegados();
            ////testDelegados+=new frmTestDelegados.testDelegado()
        }

        public void ActualizarNombre(string dato)
        {

        }

    }
}
