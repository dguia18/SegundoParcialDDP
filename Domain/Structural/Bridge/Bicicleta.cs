using Domain.Structural.Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Bridge
{
    public class Bicicleta : Vehiculo
    {
        public Bicicleta(IProceso ensamblar, IProceso pintar) : 
            base(ensamblar, pintar)
        {
        }

        public override string Fabricar()
        {
            return _ensamblar.Procesar() + " de la bicicleta y " + _pintar.Procesar();
        }
    }
}
