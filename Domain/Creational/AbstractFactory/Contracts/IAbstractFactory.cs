using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Contracts
{
    public interface IAbstractFactory
    {
        IPersonaje CrearPersonaje();
        IArma CrearArma();
    }
   
}
