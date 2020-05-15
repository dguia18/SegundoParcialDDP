using Domain.Creational.Builder;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Creational.Test.Builder.Test
{
    class BuilderTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void ProbarBuilder()
        {
            Producto producto = new Producto.ProductoBuilder("Papaya").
                SetCantidad(15).SetCosto(25000).
                Build();
            Assert.AreEqual("Papaya", producto.Nombre);
            Assert.AreEqual(15, producto.Cantidad);
            Assert.AreEqual(25000, producto.Costo);
        }
    }
}
