using Microsoft.EntityFrameworkCore;

namespace ePlants.Data
{
    public class PlantsDbContext : DbContext
    {
        public PlantsDbContext(DbContextOptions<PlantsDbContext> options) : base(options)
        {

        }
    }
}
