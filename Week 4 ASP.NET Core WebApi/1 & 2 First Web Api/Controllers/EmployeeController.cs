using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/Emp")]  
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Brishti", "Anuj", "Asmi", "Anisha" };
        }
    }
}
