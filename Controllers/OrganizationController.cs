using Microsoft.AspNetCore.Mvc;

namespace RiskManagement.Controllers
{
    [ApiController]
    [Route("api/organization")]
    public class OrganizationController: ControllerBase
    {

        [HttpGet]

    public string Test()

        {

            return "API working";
          
        }


    }
}
