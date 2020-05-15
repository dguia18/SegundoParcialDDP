using Domain.Creational.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Entities
{
    public class ArmaPolea : IArma
    {
        public string Nombre { get; set; } = "Polea";

        public string Accionar()
        {
            return "Arrojando catapulta";
        }
    }
}
