using Carter;
using Product.Command.API.Utilities;

namespace Product.Command.API.Endpoints;

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet(ApiUrlProvider.CreateProduct, () =>
        {
            return "Hello World";
        });
    }
}
