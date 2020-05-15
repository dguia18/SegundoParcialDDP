using Domain.Creational.AbstractFactory.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Entities
{
    public class PersonajeVikingo : IPersonaje
    {
        public string Nombre { get; set; } = "Ivar";
        public string Ciudad { get; set; } = "Categat";

        public string Luchar()
        {
            return $"{Nombre} luchando por {Ciudad}";
        }
    }
}
