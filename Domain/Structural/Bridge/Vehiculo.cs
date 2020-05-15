using Domain.Structural.Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Bridge
{
    public abstract class Vehiculo
    {
        protected readonly IProceso _ensamblar;
        protected readonly IProceso _pintar;
        protected Vehiculo(IProceso ensamblar, IProceso pintar)
        {
            this._ensamblar = ensamblar;
            this._pintar = pintar;
        }
        public abstract string Fabricar();
    }
}
