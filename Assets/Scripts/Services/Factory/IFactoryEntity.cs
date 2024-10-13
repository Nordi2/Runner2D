namespace Assets.Scripts.Services.Factory
{
    public interface IFactoryEntity
    {
        TImplementation GetEntity<TImplementation>(string path);
    }
}