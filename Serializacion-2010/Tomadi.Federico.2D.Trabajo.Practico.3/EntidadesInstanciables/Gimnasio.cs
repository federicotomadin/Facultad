using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;
using System.Xml.Serialization;

namespace EntidadesInstanciables
{
    [Serializable]
    [XmlInclude(typeof(Gimnasio))]
   public class Gimnasio
    {
        public enum EClases
        {
            Pilates = 0,
            Natacion = 1,
            CrossFit = 2,
            Yoga = 3
        }

        private List<Alumno> _alumnos;
        private List<Instructor> _instructores;
        private List<Jornada> _jornada;

        #region "Propiedades"
        public Jornada this[int indice]
        {
            get
            {
                if (indice < this._jornada.Count || indice > this._jornada.Count)
                    return this._jornada[indice];
                else
                    return null;
            }
        }
        #endregion


        #region "Metodos"

        public Gimnasio()
        {
            this._alumnos = new List<Alumno>();
            this._instructores = new List<Instructor>();
            this._jornada = new List<Jornada>();
        }

        public static bool Guardar(Gimnasio gim)
        {
            Xml<Gimnasio> xml = new Xml<Gimnasio>();
            if (xml.guardar("C:\\Users\\sam\\Desktop.Gimnasio.xml", gim))
            {
                //Console.WriteLine("El archivo se ha escrito correctamente");
                return true;
            }
            return false;
        }

        //Preguntarle a fede que path le tenemos que pasar 

        public static bool Leer(Gimnasio gim)
        {
            Xml<Gimnasio> xml = new Xml<Gimnasio>();
            Gimnasio aux;
            if (xml.leer("C:\\Users\\sam\\Desktop.Gimnasio.xml", out aux))
            {
                Console.WriteLine("El archivo se ha leido correctamente");
                Console.WriteLine(aux.ToString());
                return true;
            }
            return false;
        }

        /// <summary>
        /// Verifica si el alumno esta inscripto en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>

        public static bool operator ==(Gimnasio g, Alumno a)
        {
            if (!Object.ReferenceEquals(g, null) && !Object.ReferenceEquals(a, null))
            {
                foreach (Alumno item in g._alumnos)
                {
                    if (item == a)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el alumno no esta inscripto en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>

        public static bool operator !=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Verifica si el instructor se encuentra dando clases en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>

        public static bool operator ==(Gimnasio g, Instructor i)
        {
            if (!Object.ReferenceEquals(g, null) && !Object.ReferenceEquals(i, null))
            {
                foreach (Instructor item in g._instructores)
                {
                    if (item == i)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Verifica si el instructor no se encuentra dando clases en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Gimnasio g, Instructor i)
        {
            return !(g == i);
        }

        /// <summary>
        /// Agregara un alumno siempre y cuando no se encuentre en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>

        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (!Object.ReferenceEquals(g, null) && !Object.ReferenceEquals(a, null))
            {
                if (g != a)
                {
                    g._alumnos.Add(a);
                }
                else
                {
                    throw new AlumnoRepetidoException();
                }
            }
            return g;
        }

        /// <summary>
        /// Agregara un instructor al gimnasio siempre y cuando no se encuentre en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>

        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            if (!Object.ReferenceEquals(g, null) && !Object.ReferenceEquals(i, null))
            {
                if (g != i)
                {
                    g._instructores.Add(i);
                }
            }
            return g;
        }
        //Mostrar datos sera de la jornada.

        /// <summary>
        /// Metodo que mostrara los datos del gimnasio
        /// </summary>
        /// <param name="gim"></param>
        /// <returns>Retornara un string con los datos del gimnasio</returns>
        private static string MostrarDatos(Gimnasio gim)
        {
            string mensaje = "";
            foreach (Jornada item in gim._jornada)
            {
                mensaje += ((Jornada)item).ToString();
            }
            return mensaje;
        }

        /// <summary>
        /// Metodo que hara publico los datos del gimnasio
        /// </summary>
        /// <returns>Retornara un string con los datos del gimnasio</returns>

        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }

        public static Instructor operator ==(Gimnasio gim, Gimnasio.EClases clase)
        {

            if (!Object.ReferenceEquals(gim, null))
            {
                foreach (Instructor item in gim._instructores)
                {
                    if (item == clase)
                    {
                        return item;
                    }
                }
            }
            throw new SinInstructorException();
        }

        public static Instructor operator !=(Gimnasio gim, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(gim, null))
            {
                foreach (Instructor item in gim._instructores)
                {
                    if (item != clase)
                    {
                        return item;
                    }
                }
            }
            return null;
        }

        public static Gimnasio operator +(Gimnasio gim, Gimnasio.EClases clase)
        {
            if (!Object.ReferenceEquals(gim, null))
            {
                switch (clase)
                {
                    case Gimnasio.EClases.CrossFit:
                        Jornada aux = new Jornada(clase, gim == clase);
                        foreach (Alumno item in gim._alumnos)
                        {
                            if (item == clase)
                            {
                                aux += item;
                            }
                        }
                        gim._jornada.Add(aux);
                        return gim;
                    case Gimnasio.EClases.Natacion:
                        Jornada aux2 = new Jornada(clase, gim == clase);
                        foreach (Alumno item in gim._alumnos)
                        {
                            if (item == clase)
                            {
                                aux2 += item;
                            }
                        }
                        gim._jornada.Add(aux2);
                        return gim;
                    case Gimnasio.EClases.Pilates:
                        Jornada aux3 = new Jornada(clase, gim == clase);
                        foreach (Alumno item in gim._alumnos)
                        {
                            if (item == clase)
                            {
                                aux3 += item;
                            }
                        }
                        gim._jornada.Add(aux3);
                        return gim;
                    case Gimnasio.EClases.Yoga:
                        Jornada aux4 = new Jornada(clase, gim == clase);
                        foreach (Alumno item in gim._alumnos)
                        {
                            if (item == clase)
                            {
                                aux4 += item;
                            }
                        }
                        gim._jornada.Add(aux4);
                        return gim;
                }
            }
            return null;
        }
        #endregion
    }
}
