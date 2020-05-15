using Domain.Structural.Bridge.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Bridge
{
    public class Pintar : IProceso
    {
        public string Color { get; set; }

        public Pintar(string color)
        {
            Color = color;
        }

        public string Procesar()
        {
            return $"Se esta pintando con color {Color}";
        }
    }
}
