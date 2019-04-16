using System.Data.Entity;
using BMS.Core.Model;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BMS.Infrastructure.DataAccess.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<User, Role, long, Login, UserRole, Claim>
    {
        public const string DefaultConnection = "BMSConnection";
        public ApplicationDbContext() : base($"name={DefaultConnection}")
        {
        }
        public DbSet<Test> Tests { get; set; } 
    }
}
