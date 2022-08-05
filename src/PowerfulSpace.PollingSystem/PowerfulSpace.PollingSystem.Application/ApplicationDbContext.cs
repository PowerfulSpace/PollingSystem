#nullable disable

using Microsoft.EntityFrameworkCore;
using PowerfulSpace.PollingSystem.Entities;

namespace PowerfulSpace.PollingSystem.Application
{
    public class ApplicationDbContext: DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}



        public DbSet<Poll> Polls { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("IN-MEMORY");
        }

    }
}

#nullable enable