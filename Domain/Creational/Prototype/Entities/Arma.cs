using Domain.Creational.Prototype.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.Prototype.Entities
{
    public class Arma : ICloneable<Arma>
    {
        public string Nombre { get; set; }
        public double Danio { get; set; }

        public Arma ClonarProfundo()
        {
            return ClonarSuperFicial();
        }

        public Arma ClonarSuperFicial()
        {
            return new Arma
            {
                Nombre = Nombre,
                Danio = Danio
            };
        }
    }
}
