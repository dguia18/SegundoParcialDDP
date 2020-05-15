using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Decorator
{
    public class LucesDeColores : ArbolDecorador
    {
        public LucesDeColores(IArbolDeNavidad arbol)
        {
            this.arbolDeNavidad = arbol;
        }
        public override string Decorar()
        {
            return base.Decorar() + PonerLuces();
        }
        private string PonerLuces()
        {
            return " Poniendo luces de colores";
        }
    }
}
