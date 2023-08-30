using HelloWorld.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HelloWorld.Data
{
    internal class DataContextEF : DbContext
    {
        private IConfiguration _config;

        public DataContextEF(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Computer>? Computer { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer(_config.GetConnectionString("DefaultConnrction"), options => options.EnableRetryOnFailure());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("TutorialAppSchema");

            modelBuilder.Entity<Computer>().HasKey(c => c.ComputerId);
             //.HasNoKey();
            //.HasKey(c => c.Motherboard);
            //modelBuilder.Entity<Computer>().ToTable("Computer", "TutorialAppSchema");
            //                               .ToTable("TableName", "SchemaName");
        }

    }
}
