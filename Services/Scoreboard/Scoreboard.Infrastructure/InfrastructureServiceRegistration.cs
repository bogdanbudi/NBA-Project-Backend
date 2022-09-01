using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Scoreboard.Application.Contracts.Persistence;
using Scoreboard.Infrastructure.Persistence;
using Scoreboard.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Scoreboard.Infrastructure.RepositoriesFreeApi;

namespace Scoreboard.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<ScoreboardContext>(options =>
            //    options.UseSqlServer(configuration.GetConnectionString("ScoreboardConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBaseFreeApi<>));
            services.AddScoped<IGameRepository, GameRepositoryFreeApi>();

            return services;
        }
    }
}
