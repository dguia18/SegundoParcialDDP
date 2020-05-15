using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.FactoryMethod
{
    public class ProductoParaFabricarSuave : Producto
    {
        public ProductoParaFabricarSuave()
        {
            this.Especificacion = Especificacion.Suave;
        }
    }
}
