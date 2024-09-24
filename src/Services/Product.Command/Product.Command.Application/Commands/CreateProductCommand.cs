using Framework.Core.CQRS;
using Product.Command.Application.Dto;

namespace Product.Command.Application.Commands;

public record CreateProductCommand(
    string Name, 
    string Description,
    decimal Price) : ICommand<CreateProductResponse>;
