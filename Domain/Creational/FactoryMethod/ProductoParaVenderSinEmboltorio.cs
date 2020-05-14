using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoParaVenderSinEmboltorio : Producto
    {
        public ProductoParaVenderSinEmboltorio()
        {
            this.Especificacion = Especificacion.SinEmboltorio;
        }
    }
}
