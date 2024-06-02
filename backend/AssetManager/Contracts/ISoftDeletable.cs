namespace AssetManager.Contracts;

public interface ISoftDeletable
{
    DateTime? DeletedOn { get; set; }
}