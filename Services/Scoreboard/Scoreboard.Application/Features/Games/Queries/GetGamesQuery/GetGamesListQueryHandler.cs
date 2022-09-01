using AutoMapper;
using MediatR;
using Scoreboard.Application.Contracts.Persistence;

namespace Scoreboard.Application.Features.Games.Queries.GetGamesQuery
{
    public class GetGamesListQueryHandler : IRequestHandler<GetGamesListQuery, List<GamesVm>>
    {
        private readonly IGameRepository _gameRepository;
        private readonly IMapper _mapper;

        public GetGamesListQueryHandler(IGameRepository orderRepository, IMapper mapper)
        {
            _gameRepository = orderRepository;
            this._mapper = mapper;
        }

        public async Task<List<GamesVm>> Handle(GetGamesListQuery request, CancellationToken cancellationToken)
        {
           var gamesList =  await _gameRepository.GetAllAsync();
           return _mapper.Map<List<GamesVm>>(gamesList);
        }
    }
}
