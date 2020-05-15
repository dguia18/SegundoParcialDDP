
namespace Domain.Creational.FactoryMethod
{
    public interface IProductoFactory
    {
        Producto CrearProducto(Especificacion especificacion);
    }
    public enum Especificacion
    {
        MateriaPrima,
        Duro,
        Suave,
        ConEmboltorio,
        SinEmboltorio
    }
}
