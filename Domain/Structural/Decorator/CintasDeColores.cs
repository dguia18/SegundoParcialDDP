using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Decorator
{
    public class CintasDeColores : ArbolDecorador
    {
        public CintasDeColores(IArbolDeNavidad arbol) 
        {
            this.arbolDeNavidad = arbol;
        }
        public override string Decorar()
        {
            return base.Decorar() + PonerCintas();
        }
        private string PonerCintas()
        {
            return " Poniendo cintas";
        }
    }
}
