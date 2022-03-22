namespace CosmosDbPocInfra.Interfaces.CosmosDb
{
    public interface ICosmosDbClientFactory
    {
        ICosmosDbClient GetClient(string collectionName);
    }
}
