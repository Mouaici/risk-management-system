using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RiskManagement.Models;

namespace RiskManagement.Controllers
{
    [ApiController]
    [Route("api/organization")]
    public class OrganizationController: ControllerBase
    {
        private readonly RiskManagementDbContext _context;

        public OrganizationController (RiskManagementDbContext context)

        {

            _context = context;

        }

        // GET: api/dbtest

        [HttpGet]

        public async Task<IActionResult> GetOrganizations()

        {

            var orgs = await _context.Organizations.ToListAsync();

            return Ok(orgs);

        }

        // POST: api/dbtest

        [HttpPost]

        public async Task<IActionResult> AddOrganization()

        {

            var org = new Organization

            {

                Name = "Test Org",

                IsoScope = "ISO9001",

                Status = "active",

                CreatedAt = DateTime.UtcNow,

                UpdatedAt = DateTime.UtcNow

            };

            _context.Organizations.Add(org);

            await _context.SaveChangesAsync();

            return Ok(org);

        }

        

    }
}
