namespace AssetManager.Contracts;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}