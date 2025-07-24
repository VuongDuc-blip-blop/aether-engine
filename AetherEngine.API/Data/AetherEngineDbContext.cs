using Microsoft.EntityFrameworkCore;

namespace AetherEngine.API.Data
{
    public class AetherEngineDbContext : DbContext
    {

        public AetherEngineDbContext(DbContextOptions<AetherEngineDbContext> options) : base(options)
        {

        }

    }
}
