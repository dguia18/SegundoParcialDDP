using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.Prototype.Contracts
{
    public interface ICloneable<T>
    {
        T ClonarSuperFicial();
        T ClonarProfundo();
    }
}
