using Microsoft.EntityFrameworkCore;

namespace Product.Command.Application.Data;

public interface IApplicationDbContext
{
    DbSet<Domain.Models.Product> Products { get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
