using Framework.Core.CQRS;
using Product.Command.Application.Data;
using Product.Command.Application.Dto;

namespace Product.Command.Application.Commands.CreateProduct;

public class CreateProductCommandHandler(IApplicationDbContext dbContext) 
    : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Domain.Models.Product
        {
            Name = request.Name,
            Description = request.Description,
            Price = request.Price
        };

        dbContext.Products.Add(product);
        await dbContext.SaveChangesAsync(cancellationToken);

        return new CreateProductResponse(product.Id);
    }
}
