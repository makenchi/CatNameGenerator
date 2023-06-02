using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CatNameGeneratorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
