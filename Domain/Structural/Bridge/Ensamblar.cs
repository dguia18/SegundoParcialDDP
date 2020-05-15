using Domain.Structural.Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Bridge
{
    public class Ensamblar : IProceso
    {

        public string Procesar()
        {
            return "Se estan ensamblando las partes";
        }
    }
}
