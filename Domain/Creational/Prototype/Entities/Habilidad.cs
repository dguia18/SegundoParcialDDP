using Domain.Creational.Prototype.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.Prototype.Entities
{
    public class Habilidad : ICloneable<Habilidad>
    {
        public string Nombre { get; set; }
        public Habilidad ClonarProfundo()
        {
            return ClonarSuperFicial();
        }

        public Habilidad ClonarSuperFicial()
        {
            return new Habilidad
            {
                Nombre = Nombre
            };
        }
    }
}
