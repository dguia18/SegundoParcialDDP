using Domain.Structural.Decorator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Structural.Test.Decorator.Test
{
    public class DecoratorTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void DecorarArbolDeNavidad()
        {
            IArbolDeNavidad arbol = 
               new ArbolDeNavidad();

            Assert.AreEqual("Arbol de Navidad", arbol.Decorar());
            
            IArbolDeNavidad luces = 
                new LucesDeColores(arbol);

            Assert.AreEqual("Arbol de Navidad Poniendo " +
                "luces de colores", luces.Decorar());

            IArbolDeNavidad cintasDeColores =
                new CintasDeColores(luces);

            Console.WriteLine(cintasDeColores.Decorar());

            Assert.AreEqual("Arbol de Navidad Poniendo " +
                "luces de colores Poniendo cintas", cintasDeColores.Decorar());
        }
    }
}
