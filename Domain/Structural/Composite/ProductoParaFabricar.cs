using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Structural.Composite
{
    public class ProductoParaFabricar : Producto
    {
        List<Producto> Productos { get; set; }        

        public ProductoParaFabricar(string nombre, double cantidad) : base(nombre, cantidad)
        {
            this.Productos = new List<Producto>();
        }

        public ProductoParaFabricar(string nombre) : base(nombre)
        {
            this.Productos = new List<Producto>();
        }
        public void Agregar(Producto materiaPrima)
        {
            this.Productos.Add(materiaPrima);
        }

        public override double GetCosto()
        {
            double costo = 0;
            Productos.ForEach(producto => costo += producto.GetCosto());
            return costo;
        }
    }
}
