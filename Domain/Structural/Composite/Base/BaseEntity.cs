﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Composite.Base
{
    public abstract class BaseEntity
    {
    }
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
