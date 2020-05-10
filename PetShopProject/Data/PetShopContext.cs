using Microsoft.EntityFrameworkCore;
using PetShopProject.Models;

namespace PetShopProject.Data
{
    /// <summary>
    /// Context of pet shop.
    /// </summary>
    public class PetShopContext : DbContext
    {
        /// <summary>
        /// Categories of different pets.
        /// </summary>
        public DbSet<Category> Categories { get; set; }
        /// <summary>
        /// Animals available in pet shop.
        /// </summary>
        public DbSet<Animal> Animals { get; set; }
        /// <summary>
        /// Comments in the pet shop.
        /// </summary>
        public DbSet<Comment> Comments { get; set; }

        /// <summary>
        /// Create new instance of the Pet shop context.
        /// </summary>
        /// <param name="options">options of DbContext</param>
        public PetShopContext(DbContextOptions<PetShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(PrePopulateHelper.Categories);
            modelBuilder.Entity<Animal>().HasData(PrePopulateHelper.Animals);
            modelBuilder.Entity<Comment>().HasData(PrePopulateHelper.Comments);
        }
    }
}