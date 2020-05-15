using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoParaFabricarDuro : Producto
    {
        public ProductoParaFabricarDuro()
        {
            this.Especificacion = Especificacion.Duro;
        }
    }
}
