using Scoreboard.Domain.Entities;

namespace Scoreboard.Application.Contracts.Persistence
{
    public interface IGameRepository: IAsyncRepository<Game>
    {
        Task<IEnumerable<Game>> GetAllAsync();
    }
}
