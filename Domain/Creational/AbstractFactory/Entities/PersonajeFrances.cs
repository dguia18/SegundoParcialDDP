using Domain.Creational.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Entities
{
    public class PersonajeFrances : IPersonaje
    {
        public string Nombre { get; set; } = "Rolo";
        public string Ciudad { get; set; } = "Paris";

        public string Luchar()
        {
            return $"{Nombre} luchando por {Ciudad}";
        }
    }
}
