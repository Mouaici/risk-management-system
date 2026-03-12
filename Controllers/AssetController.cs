using Microsoft.AspNetCore.Mvc;

namespace RiskManagement.Controllers
{
    [ApiController]
    [Route("api/asset")]
    public class AssetController : ControllerBase
    {

        [HttpGet]

        public string Test()

        {

            return "API working";

        }


    }
}