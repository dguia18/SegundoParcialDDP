using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Composite
{
    public class ProductoMateriaPrima : Producto
    {
        public ProductoMateriaPrima(string nombre, double cantidad) : base(nombre, cantidad)
        {
        }

        public ProductoMateriaPrima(string nombre, double cantidad, double costo) : base(nombre, cantidad, costo)
        {
        }

        public override double GetCosto()
        {
            return this.Cantidad * CostoUnitario;
        }
    }
}
