using BuildingBlocks.Exceptions;

namespace Catalog.API.Properties.Exceptions;

public class ProductNotFoundException : NotFoundException
{
    public ProductNotFoundException(Guid Id) : base("Product", Id) { }
}
