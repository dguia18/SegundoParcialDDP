using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Adapter
{
    public class Vikingo : IPersonaje
    {
        public string Nombre { get; set; }
        public Vikingo(string nombre)
        {
            this.Nombre = nombre;
        }
        public string Caminar()
        {
            return $"El Vikingo {Nombre} camina normalmente";
        }
    }
}
