using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoMateriaPrima : Producto
    {
        public ProductoMateriaPrima()
        {
            this.Especificacion = Especificacion.MateriaPrima;
        }
    }
}
