using Domain.Structural.Composite;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Structural.Test.Composite.Test
{
    public class PruebaComposite
    {
        ProductoMateriaPrima leche;
        ProductoMateriaPrima azucar;
        ProductoMateriaPrima arinaPan;
        ProductoMateriaPrima platano;
        ProductoParaFabricar dulceDeLeche;
        ProductoParaFabricar dulceDeMaduro;
        ProductoParaFabricar presentacionSurtido;
        [SetUp]
        public void Setup()
        {
            leche = new ProductoMateriaPrima(cantidad: 15, nombre: "Leche", costo: 1500);
            azucar = new ProductoMateriaPrima(nombre: "Azucar", cantidad: 45, costo: 1300);
            arinaPan = new ProductoMateriaPrima(nombre: "Arina Pan", cantidad: 0.5, costo: 1300);
            platano = new ProductoMateriaPrima(nombre: "Platano", cantidad: 30, costo: 300);

            dulceDeLeche = new ProductoParaFabricar("Dulce de Leche");
            dulceDeLeche.Agregar(leche);
            dulceDeLeche.Agregar(azucar);
            dulceDeLeche.Agregar(arinaPan);

            dulceDeMaduro = new ProductoParaFabricar("Dulce de Maduro");
            dulceDeMaduro.Agregar(azucar);
            dulceDeMaduro.Agregar(platano);

            presentacionSurtido = new ProductoParaFabricar("Presentacion Surtido");
            presentacionSurtido.Agregar(dulceDeLeche);
            presentacionSurtido.Agregar(dulceDeMaduro);
        }

        [Test]
        public void ComprobarCostoDeMateriasPrimas()
        {
            Assert.AreEqual(81650, dulceDeLeche.GetCosto());
        }
        [Test]
        public void ComprobarCostoDeProductoFabricado()
        {
            Assert.AreEqual(149150, presentacionSurtido.GetCosto());
        }
    }
}
