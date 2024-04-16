using Microsoft.EntityFrameworkCore;

namespace MyMvcApp.Data
{
    // Default Db Context in entity.
    public class ApplicationDbContext : DbContext
    {
        // We are passing the options into the constructor (below) to the base class.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            // DB configuration to be passed to options we be added here.
        }
    }
}

// NOTE: this needs to be registered in Program.cs