namespace Product.Command.Application.Dto;

public record CreateProductRequest(
    string Name,
    string Description,
    decimal Price);
