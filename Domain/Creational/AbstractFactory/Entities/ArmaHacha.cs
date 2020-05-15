using Domain.Creational.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Entities
{
    public class ArmaHacha : IArma
    {
        public string Nombre { get; set; } = "Hacha";

        public string Accionar()
        {
            return $"Luchando con {Nombre}";
        }
    }
}
