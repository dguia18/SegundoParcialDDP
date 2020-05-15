using Domain.Structural.Composite.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Composite
{
    public abstract class Producto : Entity<int>
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; }
        public double CostoUnitario { get; set; }
        protected Producto(string nombre, double cantidad)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
        }
        protected Producto(string nombre, double cantidad, double costo)
        {
            this.Nombre = nombre;
            this.Cantidad = cantidad;
            this.CostoUnitario = costo;
        }
        protected Producto(string nombre)
        {
            this.Nombre = nombre;
        }
        public abstract double GetCosto();
    }
}
