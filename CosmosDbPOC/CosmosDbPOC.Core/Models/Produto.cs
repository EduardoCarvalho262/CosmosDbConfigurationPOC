using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmosDbPOC.Core.Models
{
    public class Produto : Entity
    {
        public string? Nome { get; set; }

        public string? Descricao { get; set; }

        public decimal? Preco { get; set; }
    }
}
