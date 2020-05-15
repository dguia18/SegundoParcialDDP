using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Adapter
{
    public class Frances : IPersonaje
    {
        public string Nombre { get; set; }
        public Frances(string nombre)
        {
            this.Nombre = nombre;
        }
        public string Caminar()
        {
            return $"El Frances {Nombre} camina normalmente";
        }
    }
}
