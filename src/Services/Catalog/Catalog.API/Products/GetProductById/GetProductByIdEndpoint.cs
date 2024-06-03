
namespace Catalog.API.Products.GetProductById;

//public record GetProductByIdRequest();

//careful - should match GetProductByIdHandler -  record GetProductByIdResult(Product Product); 
//otherwise Mapster will not map correctly
public record GetProductByIdResponse(Product Product);
public class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products/{id}", async (Guid id, ISender sender) =>
        {
            var result = await sender.Send(new GetProductByIdQuery(id));
            var response = result.Adapt<GetProductByIdResponse>();
            return Results.Ok(response);
        })
        .WithName("ProductById")
        .Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Get ProductBy By Id")
        .WithDescription("Get Product By Id");
    }
}
