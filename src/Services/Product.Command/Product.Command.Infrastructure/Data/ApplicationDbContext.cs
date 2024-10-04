using Microsoft.EntityFrameworkCore;
using Product.Command.Application.Data;

namespace Product.Command.Infrastructure.Data;

public class ApplicationDbContext : DbContext, IApplicationDbContext
{
    public DbSet<Domain.Models.Product> Products => Set<Domain.Models.Product>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
}
