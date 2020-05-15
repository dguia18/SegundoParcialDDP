using Domain.Structural.Bridge;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Structural.Test.BridgeTest
{
    public class BridgeTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void ProbarFabricacionDeVehiculo()
        {
            Pintar pintar = new Pintar("Rojo");
            Ensamblar ensamblar = new Ensamblar();

            Bicicleta bicicleta = new Bicicleta(ensamblar,pintar);
            Assert.AreEqual("Se estan ensamblando las partes" +
                " de la bicicleta y Se esta pintando con color Rojo",
                bicicleta.Fabricar());

            Yate yate = new Yate(ensamblar, pintar);
            Assert.AreEqual("Se estan ensamblando las partes" +
                " del yate y Se esta pintando con color Rojo",
                yate.Fabricar());
        }
    }
}
