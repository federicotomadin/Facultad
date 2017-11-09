﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

using Entidades.Punto9F;

namespace Final.Test
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entidades.Inicio.Humano h = new Entidades.Inicio.Humano("Juan", ERaza.Mestiza);
            Entidades.Inicio.Persona p = new Entidades.Inicio.Persona("Brian", "Lopez", ERaza.Cabeza, 17);
            Entidades.Inicio.Alumno a = new Entidades.Inicio.Alumno(p, 123, ENivelDeEstudio.Primaria);
            Entidades.Inicio.AlumnoEgresado ae = new Entidades.Inicio.AlumnoEgresado(a, 4.5f, 2017);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entidades.Punto2F.ClaseConstructores o = new Entidades.Punto2F.ClaseConstructores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Entidades.Punto6F.Persona p = new Entidades.Punto6F.Persona("Brian", "Lopez", ERaza.Cabeza, 17);
            Entidades.Punto6F.AlumnoEgresado a = new Entidades.Punto6F.AlumnoEgresado(new Entidades.Punto6F.Alumno(p, 123, ENivelDeEstudio.Primaria), 8.8f, 2001);

            if (a.Xml("alumno.xml"))
            {
                MessageBox.Show("Serializado OK");
            }
            else
            {
                MessageBox.Show("NO Serializado");
            }

            if (((Entidades.Punto6F.IDeserializar)a).Xml("alumno.xml", out a))
            {
                MessageBox.Show("Deserializado OK");
            }
            else
            {
                MessageBox.Show("NO Deserializado");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Entidades.Punto9F.Persona p = new Entidades.Punto9F.Persona("Peter", "Müller", ERaza.Aria, 25);
            MessageBox.Show(p.MostrarBD());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Entidades.Punto11.Salon<Entidades.Punto11.Persona> s = new Entidades.Punto11.Salon<Entidades.Punto11.Persona>(2);

            try
            {
                Entidades.Punto11.Persona p = new Entidades.Punto11.Persona("Brian", "Lopez", ERaza.Cabeza, 67);
                Entidades.Punto11.Persona p1 = new Entidades.Punto11.Persona("Jose", "Lopez", ERaza.Negra, 47);
                Entidades.Punto11.Persona p2 = new Entidades.Punto11.Persona("Brian", "Smith", ERaza.Aria, 57);

                s += p;
                s += p1;
                s += p2;
            }
            catch (Entidades.Punto10.NoAgregaException ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lanzar mediante un hilo el método ProbarTodo.");
        }

        private void ProbarTodo()//para el thread
        {
           
        }
    }
}
