using System;
using HahaFunnyJokes.Domain;
using Microsoft.EntityFrameworkCore;

namespace HahaFunnyJokes.Data
{
    public class HahaFunnyJokesDbContext : DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Joke> Jokes { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<UserHobby> UserHobbies { get; set; }

        public HahaFunnyJokesDbContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserHobby>(options => { options.HasKey(s => new {s.UserId, s.HobbyId}); });
            base.OnModelCreating(modelBuilder);
        }
    }
}
