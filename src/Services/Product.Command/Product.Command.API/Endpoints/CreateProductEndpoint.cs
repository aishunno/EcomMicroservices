using Carter;

namespace Product.Command.API.Endpoints;

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("/products", () =>
        {
            return "Hello World";
        });
    }
}
