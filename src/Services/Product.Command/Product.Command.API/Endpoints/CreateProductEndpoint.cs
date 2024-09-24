using AutoMapper;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Product.Command.API.Utilities;
using Product.Command.Application.Commands.CreateProduct;
using Product.Command.Application.Dto;

namespace Product.Command.API.Endpoints;

public class CreateProductEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost(ApiUrlProvider.CreateProduct, 
            async ([FromBody] CreateProductRequest request, IMapper mapper, ISender sender) =>
        {
            var command = mapper.Map<CreateProductCommand>(request);

            var result = await sender.Send(command);

            return result.Id;
        });
    }
}
