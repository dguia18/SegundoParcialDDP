using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Adapter
{
    public class CaminarConMuletas : IPersonaje
    {
        private readonly Lisiado _lisiado;
        public CaminarConMuletas(Lisiado lisiado)
        {
            this._lisiado = lisiado;
        }
        public string Caminar()
        {
            return $"El lisiado {_lisiado.Nombre} ahora puede " +
                $"tratar de caminar";
        }
    }
}
