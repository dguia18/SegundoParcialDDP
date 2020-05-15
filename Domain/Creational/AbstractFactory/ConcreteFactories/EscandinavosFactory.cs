using Domain.Creational.AbstractFactory.Contracts;
using Domain.Creational.AbstractFactory.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.ConcreteFactories
{
    public class EscandinavosFactory : IAbstractFactory
    {
        public IArma CrearArma()
        {
            return new ArmaHacha();
        }

        public IPersonaje CrearPersonaje()
        {
            return new PersonajeVikingo();
        }
    }
}
