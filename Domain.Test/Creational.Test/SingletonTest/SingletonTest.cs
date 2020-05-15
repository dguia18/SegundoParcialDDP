using Domain.Creational.Singleton;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Test.Creational.Test.SingletonTest
{
    public class SingletonTest
    {
        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void ProbarSingleton()
        {
            Autenticacion autenticacion = Autenticacion.GetInstance();
            autenticacion.Username = "Duvan";
            autenticacion.Password = "12345";

            Autenticacion autenticacion1 = Autenticacion.GetInstance();
            Assert.IsTrue(autenticacion.Username == autenticacion1.Username);
            Assert.IsTrue(autenticacion.Password == autenticacion1.Password);
        }
    }
}
