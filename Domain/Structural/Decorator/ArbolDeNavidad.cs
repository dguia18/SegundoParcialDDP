using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Decorator
{
    public class ArbolDeNavidad : IArbolDeNavidad
    {
        public string Decorar()
        {
            return "Arbol de Navidad";
        }
    }
}
