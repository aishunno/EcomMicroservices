namespace Product.Command.Domain.Abstractions;

public abstract class Entity : IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public string? CreatedBy { get; set; }
    public DateTime? LastModfiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
}
