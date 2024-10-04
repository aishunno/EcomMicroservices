using Product.Command.Domain.Abstractions;

namespace Product.Command.Domain.Models;

public class Product : Entity
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
}
