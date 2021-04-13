using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID
{
    public abstract class Usuario
    {
        protected string nombre;
        protected int edad;
        protected int carnet;

        public string Nombre { get => nombre; set => nombre = value; }


    }
}
