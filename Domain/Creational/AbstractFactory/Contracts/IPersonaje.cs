using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Contracts
{
    public interface IPersonaje
    {
        string Nombre { get; set; }
        string Ciudad { get; set; }
        string Luchar();
    }
}
