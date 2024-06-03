namespace Catalog.API.Properties.Exceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException() : base("Product not found") { }
    }
}
