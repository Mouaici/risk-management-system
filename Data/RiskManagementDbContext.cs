using Microsoft.EntityFrameworkCore;
using RiskManagement.Models;

   


    public class RiskManagementDbContext : DbContext

    {

        public RiskManagementDbContext(DbContextOptions<RiskManagementDbContext> options)

            : base(options)

        {

        }

        public DbSet<Organization> Organizations { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Asset> Assets { get; set; }

    }


