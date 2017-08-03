﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public interface IArchivos<T>
    {
        bool leer(string archivo, out T datos);
        bool guardar(string archivo, T datos);
    }
}
