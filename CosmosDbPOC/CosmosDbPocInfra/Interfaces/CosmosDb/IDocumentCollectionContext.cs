using CosmosDbPOC;
using Microsoft.Azure.Documents;

namespace CosmosDbPocInfra.Interfaces.CosmosDb
{
    public interface IDocumentCollectionContext<in T> where T : Produto
    {
        string CollectionName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}
