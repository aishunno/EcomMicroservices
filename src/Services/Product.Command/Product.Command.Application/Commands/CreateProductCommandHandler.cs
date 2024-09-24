using Framework.Core.CQRS;
using Product.Command.Application.Dto;

namespace Product.Command.Application.Commands;

public class CreateProductCommandHandler : ICommandHandler<CreateProductCommand, CreateProductResponse>
{
    public async Task<CreateProductResponse> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        return new CreateProductResponse(12);
    }
}
