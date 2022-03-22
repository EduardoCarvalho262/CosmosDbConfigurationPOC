using Microsoft.AspNetCore.Mvc;

namespace CosmosDbPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : Controller
    {

        public ProdutoController()
        {

        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            return null;
        }
    }
}
