﻿using Microsoft.Azure.Documents.Client;
using Microsoft.Azure.Documents;

namespace CosmosDbPocInfra.Interfaces.CosmosDb
{
    public interface ICosmosDbClient
    {
        Task<Document> ReadDocumentAsync(string documentId, RequestOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<Document> CreateDocumentAsync(object document, RequestOptions options = null,
           bool disableAutomaticIdGeneration = false,
           CancellationToken cancellationToken = default(CancellationToken));

        Task<Document> ReplaceDocumentAsync(string documentId, object document, RequestOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken));

        Task<Document> DeleteDocumentAsync(string documentId, RequestOptions options = null,
            CancellationToken cancellationToken = default(CancellationToken));
    }
}
