using Domain.Repositories;
using Domain.Services;
using Infrastructure.RepositoriesImp;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure;

public static class DependencyInjectionExtension
{
    public static IServiceCollection AddDependencyInjectionInfrastructureLayer(
        this IServiceCollection services
    )
    {
        services.AddScoped<ITaskRepository, TaskRepository>();
        services.AddScoped<TaskService>();
        return services;
    }
}
