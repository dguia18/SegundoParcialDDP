using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Creational.Builder
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public double Costo { get; set; }

        protected Producto(ProductoBuilder builder)
        {
            this.Nombre = builder.Nombre;
            this.Cantidad = builder.Cantidad;
            this.Costo = builder.Costo;
        }
        public class ProductoBuilder
        {
            public string Nombre { get; private set; }
            public double Cantidad { get; private set; }
            public double Costo { get; private set; }
            public ProductoBuilder(string nombre)
            {
                this.Nombre = nombre;
            }
            public ProductoBuilder SetCantidad(double cantidad)
            {
                this.Cantidad = cantidad;
                return this;
            }
            public ProductoBuilder SetCosto(double costo)
            {
                this.Costo = costo;
                return this;
            }
            public Producto Build()
            {
                Producto producto = new Producto(this);
                return producto;
            }
        }
    }
}
