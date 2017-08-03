using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmPrincipal
{
    public partial class frmDatos : Form
    {
        public delegate void ActualizarNombre(string valor);

        public frmDatos()
        {
            InitializeComponent();

        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
        
        }


    }
}
