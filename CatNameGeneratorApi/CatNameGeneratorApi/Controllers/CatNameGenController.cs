using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatNameGeneratorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatNameGenController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            var names = new List<string>();
            names.Add("Gabigol");
            names.Add("Arrascaeta");
            names.Add("Everton Ribeiro");

            return names;
        }
    }
}
