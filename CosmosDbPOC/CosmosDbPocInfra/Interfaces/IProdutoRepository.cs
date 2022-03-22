using CosmosDbPOC.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDbPocInfra.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
    }
}
