using Domain.Creational.Prototype.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Creational.Test.Prototype.Test
{
    public class PrototypeTest
    {
        Personaje predeterminadosRagnar;
        Personaje predeterminadosRolo;
        [SetUp]
        public void SetUp()
        {
            #region Personaje1Predeterminado
            var armas = new List<Arma> 
            {
                new Arma
                {
                    Danio = 25,
                    Nombre = "Navaja"
                }, new Arma
                {
                    Danio = 45,
                    Nombre = "Hacha"
                },
                new Arma
                {
                    Danio = 85,
                    Nombre = "Polea"
                }
            };

            List<Habilidad> habilidades = new List<Habilidad>
            {
                new Habilidad
                {
                    Nombre = "Tener muchos Hijos"
                },
                new Habilidad
                {
                    Nombre = "Dialogo"
                }
            };
            predeterminadosRagnar = new Personaje
            {
                Armas = armas,
                Habilidades = habilidades,
                Nombre = "Ragnar",
                IsRey = true,
                Origen = "Categat"
            };
            #endregion
            #region Peronaje2Predeterminado
            var armas1 = new List<Arma>
            {
                new Arma
                {
                    Nombre="Espada",
                    Danio = 35
                },
                new Arma
                {
                    Danio = 55,
                    Nombre = "Aceite"
                },
                new Arma
                {
                    Nombre ="Bola con puas",
                    Danio=75
                }
            };
            var habilidades2 = new List<Habilidad>
            {
                new Habilidad
                {
                    Nombre="Traicion"
                },
                new Habilidad
                {
                    Nombre="Despedazar"
                }
            };
            predeterminadosRolo = new Personaje
            {
                Nombre = "Rolo",
                Origen = "Paris",
                Armas = armas1,
                Habilidades = habilidades2,
                IsRey = true
            };
            #endregion
        }
        [Test]
        public void ClonacionSuperFicial()
        {
            var clonRagnar = predeterminadosRagnar.ClonarSuperFicial();
            var x = new
            {
                predeterminadosRagnar.Armas,
                predeterminadosRagnar.Habilidades,
                predeterminadosRagnar.Nombre,
                predeterminadosRagnar.Origen,
                predeterminadosRagnar.IsRey
            };
            var y = new
            {
                clonRagnar.Armas,
                clonRagnar.Habilidades,
                clonRagnar.Nombre,
                clonRagnar.Origen,
                clonRagnar.IsRey
            };
            Assert.AreEqual(x, y);
        } 
        [Test]
        public void ClonacionProfunda()
        {
            var clonRagnar = predeterminadosRagnar.ClonarProfundo();
            var x = new
            {
                predeterminadosRagnar.Armas,
                predeterminadosRagnar.Habilidades,
                predeterminadosRagnar.Nombre,
                predeterminadosRagnar.Origen,
                predeterminadosRagnar.IsRey
            };
            var y = new
            {
                clonRagnar.Armas,
                clonRagnar.Habilidades,
                clonRagnar.Nombre,
                clonRagnar.Origen,
                clonRagnar.IsRey
            };
            Assert.AreNotEqual(x, y);
        }
    }
}
