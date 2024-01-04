using Microsoft.EntityFrameworkCore;
using OpskrifterDeler.Interfaces;
using OpskrifterDeler.Models;

namespace OpskrifterDeler.DBContext
{
    public class DBDataContext : DbContext
    {
        public DBDataContext(DbContextOptions<DBDataContext> options) : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Favorite> Favorites { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Account>().ToTable("Accounts");
            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();

                entity.Property(e => e.AccountId).IsRequired();
            });

            modelBuilder.Entity<Favorite>().ToTable("Favorites");
            modelBuilder.Entity<Favorite>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();

                entity.Property(e => e.MealId).IsRequired();

                entity.HasOne(e => e.Account).WithMany(e => e.Favorite).HasForeignKey(e => e.AccountId).OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Review>().ToTable("Reviews");
            modelBuilder.Entity<Review>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().IsRequired();

                entity.Property(e => e.StarValue).HasMaxLength(5).IsRequired();

                entity.Property(e => e.MealId).IsRequired();

                entity.HasOne(e => e.Account).WithMany(e => e.Reviews).HasForeignKey(e => e.AccountId);
            });
        }
    }
}
