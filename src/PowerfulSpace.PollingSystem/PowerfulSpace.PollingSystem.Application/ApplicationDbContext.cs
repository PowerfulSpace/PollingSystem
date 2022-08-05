using Microsoft.EntityFrameworkCore;
using PowerfulSpace.PollingSystem.Entities;

namespace PowerfulSpace.PollingSystem.Application
{
    public class ApplicationDbContext: DbContext
    {
        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        //{

        //}

#nullable disable

        public DbSet<Poll> Polls { get; set; }
        public DbSet<Answer> Answers { get; set; }

#nullable enable

    }
}
