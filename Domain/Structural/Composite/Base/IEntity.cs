using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Composite.Base
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }
}
