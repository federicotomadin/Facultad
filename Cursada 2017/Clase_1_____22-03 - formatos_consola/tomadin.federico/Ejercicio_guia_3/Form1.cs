using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio_guia_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);
            int cont = 0;

            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    cont += 1;
 
                }
            }
                if (cont > 2)
                {
                    MessageBox.Show("El numero no es primo", "AVISO", MessageBoxButtons.OK);
                  

                }
                else
                {
                    MessageBox.Show("El numero es primo");
                   
                }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            
        }
    }
}
