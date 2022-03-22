using CosmosDbPOC;
using CosmosDbPOC.Core.Models;
using Microsoft.Azure.Documents;

namespace CosmosDbPocInfra.Interfaces.CosmosDb
{
    public interface IDocumentCollectionContext<in T> where T : Entity
    {
        string CollectionName { get; }

        string GenerateId(T entity);

        PartitionKey ResolvePartitionKey(string entityId);
    }
}
