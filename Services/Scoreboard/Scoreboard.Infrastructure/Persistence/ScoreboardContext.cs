using Microsoft.EntityFrameworkCore;
using Scoreboard.Domain.Common;
using Scoreboard.Domain.Entities;

namespace Scoreboard.Infrastructure.Persistence
{
    public class ScoreboardContext: DbContext
    {
        public ScoreboardContext(DbContextOptions<ScoreboardContext> options) : base(options)
        {

        }

        public DbSet<Game> Games { get; set; }

        public DbSet<Team> Teams { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<EntityBase>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        entry.Entity.CreatedBy = "Badita Bogdan";
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        entry.Entity.LastModifiedBy = "Badita Bogdan";
                        break;
                }
            }
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
