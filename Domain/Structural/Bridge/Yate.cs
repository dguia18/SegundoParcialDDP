using Domain.Structural.Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Bridge
{
    public class Yate : Vehiculo
    {
        public Yate(IProceso ensamblar, IProceso pintar) : base(ensamblar, pintar)
        {
        }

        public override string Fabricar()
        {
            return _ensamblar.Procesar()+ " del yate y " + _pintar.Procesar();
        }
    }
}
