namespace Domain.Creational.FactoryMethod
{
    public abstract class Producto
    {
        public string Nombre { get; set; }
        public Especificacion Especificacion { get; set; }
        protected Producto()
        {

        }
    }
}