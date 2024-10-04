namespace Product.Command.Domain.Abstractions;

public interface IEntity
{
    public int Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? CreatedBy { get; set; }
    public DateTime? LastModfiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
}
