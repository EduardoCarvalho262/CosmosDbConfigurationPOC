using CosmosDbPOC.Core.Models;
using CosmosDbPocInfra.Interfaces;
using CosmosDbPocInfra.Interfaces.CosmosDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDbPocInfra.Repositorys
{
    public class ProdutoRepository : CosmosDbRepository<Produto>, IProdutoRepository
    {

        public ProdutoRepository(ICosmosDbClientFactory factory) : base(factory){ }
        public override string CollectionName { get; } = "";

    }
}
