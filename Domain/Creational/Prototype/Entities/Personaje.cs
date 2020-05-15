using Domain.Creational.Prototype.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Creational.Prototype.Entities
{
    public class Personaje : ICloneable<Personaje>
    {
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public bool IsRey { get; set; }
        public List<Arma> Armas { get; set; }
        public List<Habilidad> Habilidades { get; set; }
        public Personaje ClonarProfundo()
        {
            return new Personaje
            {
                Nombre = Nombre,
                Origen = Origen,
                IsRey = IsRey,
                Armas = Armas.Select(x => x.ClonarProfundo()).ToList(),
                Habilidades = Habilidades.Select(x => x.ClonarProfundo()).ToList()
            };
        }

        public Personaje ClonarSuperFicial()
        {
            return new Personaje
            {
                Nombre = Nombre,
                Origen = Origen,
                IsRey = IsRey,
                Armas = Armas,
                Habilidades = Habilidades
            };
        }
    }
}
