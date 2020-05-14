using Domain.Creational.FactoryMethod;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Creational.Test.FactoryMethod.Test
{
    public class FactoryMethodTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void CrearProductoMateriaPrima()
        {
            Producto producto = new ProductoSinEspecificacionFactory().
                CrearProducto(Especificacion.MateriaPrima);
            Assert.IsTrue(producto is ProductoMateriaPrima);
        }
        [Test]
        public void CrearProductoParaFabricarDuro()
        {
            Producto producto = new ProductoParaFabricarFactory().
                CrearProducto(Especificacion.Duro);
            Assert.IsTrue(producto is ProductoParaFabricarDuro);
        }[Test]
        public void CrearProductoParaFabricarSuave()
        {
            Producto producto = new ProductoParaFabricarFactory().
                CrearProducto(Especificacion.Suave);
            Assert.IsTrue(producto is ProductoParaFabricarSuave);
        }[Test]
        public void CrearProductoParaVenderConEmboltorio()
        {
            Producto producto = new ProductoParaVenderFactory().
                CrearProducto(Especificacion.ConEmboltorio);
            Assert.IsTrue(producto is ProductoParaVenderConEmboltorio);
        }[Test]
        public void CrearProductoParaVenderSinEmboltorio()
        {
            Producto producto = new ProductoParaVenderFactory().
                CrearProducto(Especificacion.SinEmboltorio);
            Assert.IsTrue(producto is ProductoParaVenderSinEmboltorio);
        }
    }
}
