using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoParaVenderConEmboltorio : Producto
    {
        public ProductoParaVenderConEmboltorio()
        {
            this.Especificacion = Especificacion.ConEmboltorio;
        }
    }
}
