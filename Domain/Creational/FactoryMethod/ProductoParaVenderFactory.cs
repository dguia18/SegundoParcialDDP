using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoParaVenderFactory : IProductoFactory
    {
        public Producto CrearProducto(Especificacion especificacion)
        {
            return especificacion switch
            {
                Especificacion.ConEmboltorio => new ProductoParaVenderConEmboltorio(),
                Especificacion.SinEmboltorio => new ProductoParaVenderSinEmboltorio(),
                _ => throw new
                    InvalidOperationException("No es de tipo para Vender"),
            };
        }
    }
}
