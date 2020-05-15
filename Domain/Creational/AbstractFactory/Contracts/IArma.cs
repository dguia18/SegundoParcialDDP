using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.AbstractFactory.Contracts
{
    public interface IArma
    {
        string Nombre { get; set; }
        string Accionar();
    }
}
