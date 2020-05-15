using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Decorator
{
    public abstract class ArbolDecorador : IArbolDeNavidad
    {
        protected IArbolDeNavidad arbolDeNavidad;
        public virtual string Decorar()
        {
            return arbolDeNavidad.Decorar();
        }
    }
}
