using Domain.Structural.Adapter;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Structural.Test.Adapter
{
    
    public class AdapterTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void ProbarSerLibre()
        {
            Vikingo personaje = new Vikingo("Ragnar");
            Frances frances = new Frances("Rollo");

            Assert.AreEqual("El Vikingo Ragnar" +
                " camina normalmente", personaje.Caminar());
            
            Assert.AreEqual("El Frances Rollo" +
                " camina normalmente", frances.Caminar());

            Lisiado lisiado = new Lisiado("Ivar");
            CaminarConMuletas caminarConMuletas = new CaminarConMuletas(lisiado);
            
            Assert.AreEqual("El lisiado Ivar ahora puede " +
                $"tratar de caminar", caminarConMuletas.Caminar());
        }
    }
}
