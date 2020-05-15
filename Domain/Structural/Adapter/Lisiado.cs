using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Adapter
{
    public class Lisiado
    {
        public string Nombre { get; set; }
        public Lisiado(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
