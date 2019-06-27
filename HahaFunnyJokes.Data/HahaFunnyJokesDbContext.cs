using System;
using HahaFunnyJokes.Domain;
using Microsoft.EntityFrameworkCore;

namespace HahaFunnyJokes.Data
{
    public class HahaFunnyJokesDbContext : DbContext
    {

        public DbSet<User> Users { get; set; }

        public DbSet<Joke> Jokes { get; set; }

        public DbSet<Hobby> Hobbies { get; set; }

        public DbSet<UserHobby> UserHobbies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }

        public HahaFunnyJokesDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>(options =>
            {
                options.HasAlternateKey(s => new { s.Slug, s.Email });
                options.Property(b => b.IsAdmin).HasDefaultValue(0);
            });
            modelBuilder.Entity<Hobby>(options => { options.HasAlternateKey(s => new { s.Slug }); });
            modelBuilder.Entity<Category>(options => { options.HasAlternateKey(s => new { s.Slug }); });
            modelBuilder.Entity<Joke>(options => { options.HasAlternateKey(s => new { s.Slug }); });

            modelBuilder.Entity<UserHobby>(options => { options.HasKey(s => new { s.UserId, s.HobbyId }); });

            base.OnModelCreating(modelBuilder);
        }
    }
}
