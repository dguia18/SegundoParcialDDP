using Domain.Creational.AbstractFactory.ConcreteFactories;
using Domain.Creational.AbstractFactory.Contracts;
using Domain.Creational.AbstractFactory.Entities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Creational.Test.AbstractFactory.Test
{
    public class AbstractFactoryTest
    {
        IAbstractFactory factory;
        [SetUp]
        public void SetUp()
        {
            
        }
        [Test]
        public void CrearEscandinavos()
        {
            factory = new EscandinavosFactory();
            IPersonaje personaje = factory.CrearPersonaje();
            IArma arma = factory.CrearArma();

            Assert.IsTrue(personaje is PersonajeVikingo);
            Assert.IsTrue(arma is ArmaHacha);

            Assert.AreEqual("Ivar luchando por Categat", personaje.Luchar());
            Assert.AreEqual("Luchando con Hacha", arma.Accionar());
        }
        
        [Test]
        public void CrearFranceses()
        {
            factory = new FrancesesFactory();
            IPersonaje personaje = factory.CrearPersonaje();
            IArma arma = factory.CrearArma();

            Assert.IsTrue(personaje is PersonajeFrances);
            Assert.IsTrue(arma is ArmaPolea);

            Assert.AreEqual("Rolo luchando por Paris", personaje.Luchar());
            Assert.AreEqual("Arrojando catapulta", arma.Accionar());
        }
    }
}
