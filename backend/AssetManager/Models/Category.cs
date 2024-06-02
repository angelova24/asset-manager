using System.ComponentModel.DataAnnotations;
using AssetManager.Contracts;

namespace AssetManager.Models;

public class Category : IEntity<Guid>, ISoftDeletable
{
    [Key]
    public Guid Id { get; set; }

    [MinLength(3), MaxLength(50)]
    public string Label { get; set; } = null!;

    [StringLength(150)]
    public string? Description { get; set; }
    
    public DateTime? DeletedOn { get; set; }
    
    [Timestamp]
    public byte[] Timestamp { get; set; }
}