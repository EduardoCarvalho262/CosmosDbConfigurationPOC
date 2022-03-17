using Microsoft.AspNetCore.Mvc;

namespace CosmosDbPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PessoaController : Controller
    {

        public PessoaController()
        {

        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            return null;
        }
    }
}
