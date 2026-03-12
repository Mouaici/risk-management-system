using Microsoft.AspNetCore.Mvc;

namespace RiskManagement.Controllers
{
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {

        [HttpGet]

        public string Test()

        {

            return "API working";

        }


    }
}