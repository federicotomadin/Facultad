using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Pintura
{
   public class Deposito<T>
    {
        private int _cantMax;
        private List<T> _Lista;

      

        public Deposito(int cant)
        {
            this._Lista = new List<T>();
            this._cantMax = cant;
        }


        public static bool Guardar(string depo)
        {
              bool flag = false;
              Binarios text = new Binarios();

              try
              {
                  text.guardar(depo);
                  flag = true;
              }
              catch (Exception)
              {
                  throw;
              }

              return flag;
        }

        public static bool operator ==(Deposito<T> depo, T articulo)
        {
            foreach (T item in depo._Lista)
            {
                if (item.Equals(articulo)) return true;
            }
            return false;
        }

        public static bool operator !=(Deposito<T> depo, T articulo)
        {
            return !(depo == articulo);
        }



        public static bool operator +(Deposito<T> depo, T articulo)
        {

            foreach (T item in depo._Lista)
            {
                if (item.Equals(articulo) || depo._Lista.Count >= depo._cantMax)
                    return false;

            }
            depo._Lista.Add(articulo);
            return true;

        }


        public bool Agregar(T articulo)
        {
            if (this + articulo)
                return true;

            else return false;
        }


        public bool EstaEnElDeposito(T articulo)
        {
            if (this == articulo)
                return true;

            else return false;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach(T item in this._Lista)
            {
                sb.AppendLine(item.ToString());
                

            }
            return sb.ToString();

        }


    }
}
