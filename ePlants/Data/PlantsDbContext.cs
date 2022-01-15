using Microsoft.EntityFrameworkCore;
using ePlants.Models;

namespace ePlants.Data
{
    public class PlantsDbContext : DbContext
    {
        public PlantsDbContext(DbContextOptions<PlantsDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant_Manufacturer>().HasKey(pm => new
            {
                pm.PlantId,
                pm.ManufacturerId
            });

            modelBuilder.Entity<Plant_Manufacturer>()
                .HasOne(p => p.Plant)
                .WithMany(pm => pm.Plants_Manufacturers)
                .HasForeignKey(pi => pi.PlantId);

            modelBuilder.Entity<Plant_Manufacturer>()
                .HasOne(m => m.Manufacturer)
                .WithMany(pm => pm.Plants_Manufacturers)
                .HasForeignKey(mi => mi.ManufacturerId);

            modelBuilder.Entity<Plant_Features>().HasKey(pf => new
            {
                pf.PlantId,
                pf.FeatureId
            });

            modelBuilder.Entity<Plant_Features>()
                .HasOne(p => p.Plant)
                .WithMany(pf => pf.Plants_Features)
                .HasForeignKey(pi => pi.PlantId);

            modelBuilder.Entity<Plant_Features>()
                .HasOne(f => f.Feature)
                .WithMany(pf => pf.Plants_Features)
                .HasForeignKey(fi => fi.FeatureId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<CustomerModel> Customers { get; set; }
        public DbSet<PlantModel> Plants { get; set; }
        public DbSet<Plant_Manufacturer> Plants_Manufacturers { get; set; }
        public DbSet<Plant_Features> Plants_Features { get; set; }
        public DbSet<FeatureModel> Features { get; set; }
        public DbSet<SizeModel> Sizes { get; set; }
        public DbSet<ShapeModel> Shapes { get; set; }
        public DbSet<ManufacturerModel> Manufacturers { get; set; }
        public DbSet<AddressModel> Addresses { get; set; }
        public DbSet<CityModel> Cities { get; set; }
        public DbSet<CountyModel> Counties { get; set; }

    }
}
