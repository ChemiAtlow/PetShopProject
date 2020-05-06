using Microsoft.EntityFrameworkCore;
using PetShopProject.Models;

namespace PetShopProject.Data
{
    public class PetShopContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Comment> Comments { get; set; }

        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(PrePopulateHelper.Categories);
        }
    }
}