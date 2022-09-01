using Microsoft.EntityFrameworkCore;
using Scoreboard.Application.Contracts.Persistence;
using Scoreboard.Domain.Entities;
using Scoreboard.Infrastructure.Persistence;

namespace Scoreboard.Infrastructure.Repositories
{
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(ScoreboardContext dbContext) : base(dbContext)
        {
        }

        async Task<IEnumerable<Game>> IGameRepository.GetAllAsync()
        {
            var orderList = await _dbContext
                         .Games
                         .ToListAsync();
            return orderList;
        }
    }
}
