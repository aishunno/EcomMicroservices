using Framework.Core.CQRS;
using Product.Command.Application.Dto;

namespace Product.Command.Application.Commands.CreateProduct;

public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price) : ICommand<CreateProductResponse>;
